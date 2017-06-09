// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScheduleOperations.
    /// </summary>
    public static partial class ScheduleOperationsExtensions
    {
            /// <summary>
            /// Create a schedule.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create or update schedule operation.
            /// </param>
            public static Schedule CreateOrUpdate(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, ScheduleCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, automationAccountName, scheduleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a schedule.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create or update schedule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> CreateOrUpdateAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, ScheduleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, scheduleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the update schedule operation.
            /// </param>
            public static Schedule Update(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, ScheduleUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, automationAccountName, scheduleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the update schedule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> UpdateAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, ScheduleUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, scheduleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            public static Schedule Get(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, scheduleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> GetAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, scheduleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            public static void Delete(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, scheduleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the schedule identified by schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='scheduleName'>
            /// The schedule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, string scheduleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, scheduleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a list of schedules.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            public static IPage<Schedule> ListByAutomationAccount(this IScheduleOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of schedules.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Schedule>> ListByAutomationAccountAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of schedules.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Schedule> ListByAutomationAccountNext(this IScheduleOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of schedules.
            /// <see href="http://aka.ms/azureautomationsdk/scheduleoperations" />
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
            public static async Task<IPage<Schedule>> ListByAutomationAccountNextAsync(this IScheduleOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
