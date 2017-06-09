// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkflowTriggerHistoriesOperations.
    /// </summary>
    public static partial class WorkflowTriggerHistoriesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<WorkflowTriggerHistory> List(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, ODataQuery<WorkflowTriggerHistoryFilter> odataQuery = default(ODataQuery<WorkflowTriggerHistoryFilter>))
            {
                return ((IWorkflowTriggerHistoriesOperations)operations).ListAsync(resourceGroupName, workflowName, triggerName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowTriggerHistory>> ListAsync(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, ODataQuery<WorkflowTriggerHistoryFilter> odataQuery = default(ODataQuery<WorkflowTriggerHistoryFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a workflow trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name. Corresponds to the run name for triggers
            /// that resulted in a run.
            /// </param>
            public static WorkflowTriggerHistory Get(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName)
            {
                return operations.GetAsync(resourceGroupName, workflowName, triggerName, historyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name. Corresponds to the run name for triggers
            /// that resulted in a run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowTriggerHistory> GetAsync(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, historyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resubmits a workflow run based on the trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name. Corresponds to the run name for triggers
            /// that resulted in a run.
            /// </param>
            public static void Resubmit(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName)
            {
                operations.ResubmitAsync(resourceGroupName, workflowName, triggerName, historyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resubmits a workflow run based on the trigger history.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='historyName'>
            /// The workflow trigger history name. Corresponds to the run name for triggers
            /// that resulted in a run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResubmitAsync(this IWorkflowTriggerHistoriesOperations operations, string resourceGroupName, string workflowName, string triggerName, string historyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResubmitWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, historyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowTriggerHistory> ListNext(this IWorkflowTriggerHistoriesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow trigger histories.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowTriggerHistory>> ListNextAsync(this IWorkflowTriggerHistoriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
