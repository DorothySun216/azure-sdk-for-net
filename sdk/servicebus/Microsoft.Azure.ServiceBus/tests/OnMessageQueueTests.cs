// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus.UnitTests
{
    using Microsoft.Azure.ServiceBus.Core;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class OnMessageQueueTests : SenderReceiverClientTestBase
    {
        public static IEnumerable<object[]> TestPermutations => new object[][]
        {
            // Expected structure: { usePartitionedQueue, useSessionQueue, maxCurrentCalls }
            new object[] { false, false, 1 },
            new object[] { false, false, 10 },
            new object[] { true, false, 1 },
            new object[] { true, false, 10 },
        };

        private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs eventArgs)
        {
            TestUtility.Log($"Exception Received: ClientId: {eventArgs.ExceptionReceivedContext.ClientId}, EntityPath: {eventArgs.ExceptionReceivedContext.EntityPath}, Exception: {eventArgs.Exception.Message}");
            return Task.CompletedTask;
        }

        [Fact]
        async Task Test()
        {
            try
            {
                RandomF();
                Console.WriteLine("in try");
                //throw new Exception("hello");
                return;
            }
            catch
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine("in catch");
                return; 
            }
            finally
            {
                Console.WriteLine("in finally");
            }

            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("after the try-catch-finally block");
        }


        private void RandomF()
        {
            System.Random random = new System.Random();
            int num = random.Next();
            if (num > 0)
            {
                Console.WriteLine("not throw");
            }
            else
            {
                throw new Exception("hello");
            }
        }

        [Fact]
        public async Task Unregister()
        {
            var messageCount = 10;
            var messageSender = new MessageSender("Endpoint=sb://contoso.servicebus.onebox.windows-int.net/;SharedAccessKeyName=DefaultNamespaceSasAllKeyName;SharedAccessKey=8864/auVd3qDC75iTjBL1GJ4D2oXC6bIttRd0jzDZ+g=", "unregister");
            var messageReceiver = new MessageReceiver("Endpoint=sb://contoso.servicebus.onebox.windows-int.net/;SharedAccessKeyName=DefaultNamespaceSasAllKeyName;SharedAccessKey=8864/auVd3qDC75iTjBL1GJ4D2oXC6bIttRd0jzDZ+g=", "unregister");

            var count = 0;
            await TestUtility.SendMessagesAsync(messageSender, messageCount);
            messageReceiver.RegisterMessageHandler(
                async (message, token) =>
                {
                    TestUtility.Log($"Received message: SequenceNumber: {message.SystemProperties.SequenceNumber}");
                    Interlocked.Increment(ref count);
                    if (messageReceiver.ReceiveMode == ReceiveMode.PeekLock)
                    {
                        await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
                    }
                },
                new MessageHandlerOptions(ExceptionReceivedHandler) { MaxConcurrentCalls = 3, AutoComplete = false });

            // Wait for the OnMessage Tasks to finish
            var stopwatch = Stopwatch.StartNew();
            while (stopwatch.Elapsed.TotalSeconds <= 60)
            {
                if (count == messageCount)
                {
                    TestUtility.Log($"All '{messageCount}' messages Received.");
                    break;
                }
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
            Assert.True(count == messageCount);

            // Unregister the message handler and the receive should not happen
            await messageReceiver.UnregisterMessageHandler();
            //await Task.Delay(TimeSpan.FromMinutes(3));
            await TestUtility.SendMessagesAsync(messageSender, messageCount);

            stopwatch = Stopwatch.StartNew();
            count = 0;
            while (stopwatch.Elapsed.TotalSeconds <= 60)
            {
                if (count == messageCount)
                {
                    TestUtility.Log($"All '{messageCount}' messages Received.");
                    break;
                }
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
            Console.WriteLine("COUNT: ", count);
            //Assert.True(count == 0);
        }

        [Theory]
        [MemberData(nameof(TestPermutations))]
        [LiveTest]
        [DisplayTestMethodName]
        public Task OnMessagePeekLockWithAutoCompleteTrue(bool partitioned, bool sessionEnabled, int maxConcurrentCalls)
        {
            return this.OnMessageTestAsync(partitioned, sessionEnabled, maxConcurrentCalls, ReceiveMode.PeekLock, true);
        }

        [Theory]
        [MemberData(nameof(TestPermutations))]
        [LiveTest]
        [DisplayTestMethodName]
        public Task OnMessagePeekLockWithAutoCompleteFalse(bool partitioned, bool sessionEnabled, int maxConcurrentCalls)
        {
            return this.OnMessageTestAsync(partitioned, sessionEnabled, maxConcurrentCalls, ReceiveMode.PeekLock, false);
        }

        [Theory]
        [MemberData(nameof(TestPermutations))]
        [LiveTest]
        [DisplayTestMethodName]
        public Task OnMessageReceiveDelete(bool partitioned, bool sessionEnabled, int maxConcurrentCalls)
        {
            return this.OnMessageTestAsync(partitioned, sessionEnabled, maxConcurrentCalls, ReceiveMode.ReceiveAndDelete, false);
        }

        [Theory]
        [MemberData(nameof(TestPermutations))]
        [LiveTest]
        [DisplayTestMethodName]
        public async Task OnMessageRegistrationWithoutPendingMessagesReceiveAndDelete(bool partitioned, bool sessionEnabled, int maxConcurrentCalls)
        {
            await ServiceBusScope.UsingQueueAsync(partitioned, sessionEnabled, async queueName =>
            {
                var queueClient = new QueueClient(TestUtility.NamespaceConnectionString, queueName, ReceiveMode.ReceiveAndDelete);
                try
                {
                    await this.OnMessageRegistrationWithoutPendingMessagesTestCase(queueClient.InnerSender, queueClient.InnerReceiver, maxConcurrentCalls, true);
                }
                finally
                {
                    await queueClient.CloseAsync();
                }
            });
        }

        [Fact]
        [LiveTest]
        [DisplayTestMethodName]
        public async Task OnMessageExceptionHandlerCalledTest()
        {
            var invalidQueueName = "nonexistentqueuename";
            var exceptionReceivedHandlerCalled = false;

            var queueClient = new QueueClient(TestUtility.NamespaceConnectionString, invalidQueueName, ReceiveMode.ReceiveAndDelete);
            queueClient.RegisterMessageHandler(
                (message, token) => throw new Exception("Unexpected exception: Did not expect messages here"),
                (eventArgs) =>
                {
                    Assert.NotNull(eventArgs);
                    Assert.NotNull(eventArgs.Exception);
                    if (eventArgs.Exception is MessagingEntityNotFoundException)
                    {
                        exceptionReceivedHandlerCalled = true;
                    }
                    return Task.CompletedTask;
                });

            try
            {
                var stopwatch = Stopwatch.StartNew();
                while (stopwatch.Elapsed.TotalSeconds <= 10)
                {
                    if (exceptionReceivedHandlerCalled)
                    {
                        break;
                    }

                    await Task.Delay(TimeSpan.FromSeconds(1));
                }

                TestUtility.Log($"{DateTime.Now}: ExceptionReceivedHandlerCalled: {exceptionReceivedHandlerCalled}");
                Assert.True(exceptionReceivedHandlerCalled);
            }
            finally
            {
                await queueClient.CloseAsync();
            }
        }

        private async Task OnMessageTestAsync(bool partitioned, bool sessionEnabled, int maxConcurrentCalls, ReceiveMode mode, bool autoComplete)
        {
            const int messageCount = 10;

            await ServiceBusScope.UsingQueueAsync(partitioned, sessionEnabled, async queueName =>
            {
                var queueClient = new QueueClient(TestUtility.NamespaceConnectionString, queueName, mode);
                try
                {
                    await this.OnMessageAsyncTestCase(
                        queueClient.InnerSender,
                        queueClient.InnerReceiver,
                        maxConcurrentCalls,
                        autoComplete,
                        messageCount);
                }
                finally
                {
                    await queueClient.CloseAsync();
                }
            });
        }
    }
}