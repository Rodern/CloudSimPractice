using CloudSim.Machines;
using CloudSim.Scheduling;

namespace CloudSim.Centers
{
    /// <summary>
    /// Represents a data center in the cloud simulation.
    /// </summary>
    public class DataCenter
    {
        /// <summary>
        /// Gets or sets the name of the data center.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual machines in the data center.
        /// </summary>
        public List<VirtualMachine> VirtualMachines { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCenter"/> class.
        /// </summary>
        /// <param name="name">The name of the data center.</param>
        public DataCenter(string name)
        {
            Name = name;
            VirtualMachines = new List<VirtualMachine>();
        }

        /// <summary>
        /// Adds a virtual machine to the data center.
        /// </summary>
        /// <param name="vm">The virtual machine to add.</param>
        public void AddVirtualMachine(VirtualMachine vm)
        {
            VirtualMachines.Add(vm);
        }

        /// <summary>
        /// Allocates resources to a task based on available virtual machines.
        /// </summary>
        /// <param name="task">The task that requires resource allocation.</param>
        public void AllocateResources(CloudTask task)
        {
            foreach (var vm in VirtualMachines)
            {
                if (vm.IsAvailable && vm.CpuCores >= task.RequiredCpuCores && vm.Memory >= task.RequiredMemory)
                {
                    vm.IsAvailable = false;
                    vm.ExecuteTask(task);
                    Console.WriteLine($"CloudTask {task.TaskId} allocated to VM {vm.Id}");
                    return;
                }
            }
            Console.WriteLine($"No available VM found for CloudTask {task.TaskId}");
        }
    }
}
