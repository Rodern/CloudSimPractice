using CloudSim.Centers;
using CloudSim.Scheduling;

namespace CloudSim.Connections
{
    /// <summary>
    /// Represents a network in the cloud simulation.
    /// </summary>
    public class Network
    {
        /// <summary>
        /// Gets or sets the name of the network.
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// Gets or sets the list of data centers in the network.
        /// </summary>
        public List<DataCenter> DataCenters { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Network"/> class.
        /// </summary>
        /// <param name="networkName">The name of the network.</param>
        public Network(string networkName)
        {
            NetworkName = networkName;
            DataCenters = new List<DataCenter>();
        }

        /// <summary>
        /// Adds a data center to the network.
        /// </summary>
        /// <param name="dataCenter">The data center to add.</param>
        public void AddDataCenter(DataCenter dataCenter)
        {
            DataCenters.Add(dataCenter);
        }

        /// <summary>
        /// Schedules a task in the network.
        /// </summary>
        /// <param name="task">The cloud task to schedule.</param>
        public void ScheduleTask(CloudTask task)
        {
            foreach (var dataCenter in DataCenters)
            {
                foreach (var vm in dataCenter.VirtualMachines)
                {
                    if (vm.IsAvailable && vm.CpuCores >= task.RequiredCpuCores && vm.Memory >= task.RequiredMemory)
                    {
                        dataCenter.AllocateResources(task);
                        return;
                    }
                }
            }
            Console.WriteLine($"CloudTask {task.TaskId} could not be allocated to any VM.");
        }
    }

}
