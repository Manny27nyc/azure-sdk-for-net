// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Create or update a worker pool. </summary>
    public partial class AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation : Operation<HostingEnvironmentWorkerPool>, IOperationSource<HostingEnvironmentWorkerPool>
    {
        private readonly OperationInternals<HostingEnvironmentWorkerPool> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation for mocking. </summary>
        protected AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation()
        {
        }

        internal AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<HostingEnvironmentWorkerPool>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "AppServiceEnvironmentCreateOrUpdateWorkerPoolOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override HostingEnvironmentWorkerPool Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HostingEnvironmentWorkerPool>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HostingEnvironmentWorkerPool>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        HostingEnvironmentWorkerPool IOperationSource<HostingEnvironmentWorkerPool>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new HostingEnvironmentWorkerPool(_operationBase, WorkerPoolResourceData.DeserializeWorkerPoolResourceData(document.RootElement));
        }

        async ValueTask<HostingEnvironmentWorkerPool> IOperationSource<HostingEnvironmentWorkerPool>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new HostingEnvironmentWorkerPool(_operationBase, WorkerPoolResourceData.DeserializeWorkerPoolResourceData(document.RootElement));
        }
    }
}
