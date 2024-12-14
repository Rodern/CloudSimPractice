using CloudSim.Connections;
using CloudSim.Scheduling;
using System.Net;

namespace CloudSim.Logic
{
    /// <summary>
    /// Represents the cloud simulation.
    /// </summary>
    public class CloudSimulation
    {
        /// <summary>
        /// Gets or sets the network for the simulation.
        /// </summary>
        public Network Network { get; set; }

        /// <summary>
        /// Gets or sets the list of cloud tasks in the simulation.
        /// </summary>
        public List<CloudTask> Tasks { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudSimulation"/> class.
        /// </summary>
        /// <param name="network">The network for the simulation.</param>
        public CloudSimulation(Network network)
        {
            Network = network;
            Tasks = new List<CloudTask>();
        }

        /// <summary>
        /// Adds a task to the simulation.
        /// </summary>
        /// <param name="task">The cloud task to add.</param>
        public void AddTask(CloudTask task)
        {
            Tasks.Add(task);
        }

        /// <summary>
        /// Runs the cloud simulation by allocating cloud tasks to virtual machines and executing them.
        /// </summary>
        public void RunSimulation()
        {
            Console.WriteLine("Running cloud simulation...");

            foreach (var task in Tasks)
            {
                bool taskAllocated = false;

                foreach (var dataCenter in Network.DataCenters)
                {
                    foreach (var vm in dataCenter.VirtualMachines)
                    {
                        if (vm.IsAvailable && vm.CpuCores >= task.RequiredCpuCores && vm.Memory >= task.RequiredMemory)
                        {
                            dataCenter.AllocateResources(task);
                            taskAllocated = true;
                            break;
                        }
                    }

                    if (taskAllocated)
                    {
                        break;
                    }
                }

                if (!taskAllocated)
                {
                    Console.WriteLine($"CloudTask {task.TaskId} could not be allocated to any VM.");
                }
            }

            Console.WriteLine("Cloud simulation completed.");
        }
    }
}
