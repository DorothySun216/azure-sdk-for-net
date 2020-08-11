// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The DeploymentScripts service client. </summary>
    public partial class DeploymentScriptsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeploymentScriptsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of DeploymentScriptsOperations for mocking. </summary>
        protected DeploymentScriptsOperations()
        {
        }
        /// <summary> Initializes a new instance of DeploymentScriptsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal DeploymentScriptsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new DeploymentScriptsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Updates deployment script tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentScript>> UpdateAsync(string resourceGroupName, string scriptName, DeploymentScriptUpdateParameter deploymentScript = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, scriptName, deploymentScript, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates deployment script tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentScript> Update(string resourceGroupName, string scriptName, DeploymentScriptUpdateParameter deploymentScript = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, scriptName, deploymentScript, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentScript>> GetAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentScript> Get(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, scriptName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a deployment script. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a deployment script. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, scriptName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptLogsList>> GetLogsAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.GetLogs");
            scope.Start();
            try
            {
                return await RestClient.GetLogsAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptLogsList> GetLogs(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.GetLogs");
            scope.Start();
            try
            {
                return RestClient.GetLogs(resourceGroupName, scriptName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptLog>> GetLogsDefaultAsync(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.GetLogsDefault");
            scope.Start();
            try
            {
                return await RestClient.GetLogsDefaultAsync(resourceGroupName, scriptName, tail, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptLog> GetLogsDefault(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.GetLogsDefault");
            scope.Start();
            try
            {
                return RestClient.GetLogsDefault(resourceGroupName, scriptName, tail, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentScript> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentScript> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentScript> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentScript> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<DeploymentScriptsCreateOperation> StartCreateAsync(string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateAsync(resourceGroupName, scriptName, deploymentScript, cancellationToken).ConfigureAwait(false);
                return new DeploymentScriptsCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, scriptName, deploymentScript).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DeploymentScriptsCreateOperation StartCreate(string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptsOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Create(resourceGroupName, scriptName, deploymentScript, cancellationToken);
                return new DeploymentScriptsCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, scriptName, deploymentScript).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
