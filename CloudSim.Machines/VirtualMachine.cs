using CloudSim.Scheduling;

namespace CloudSim.Machines
{
    /// <summary>
    /// Represents a virtual machine in the cloud simulation.
    /// </summary>
    public class VirtualMachine
    {
        /// <summary>
        /// Gets or sets the ID of the virtual machine.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number of CPU cores in the virtual machine.
        /// </summary>
        public int CpuCores { get; set; }

        /// <summary>
        /// Gets or sets the memory of the virtual machine in MB.
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the virtual machine is available.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachine"/> class.
        /// </summary>
        /// <param name="id">The ID of the virtual machine.</param>
        /// <param name="cpuCores">The number of CPU cores.</param>
        /// <param name="memory">The memory in MB.</param>
        public VirtualMachine(string id, int cpuCores, int memory)
        {
            Id = id;
            CpuCores = cpuCores;
            Memory = memory;
            IsAvailable = true;
        }

        /// <summary>
        /// Executes a cloud task on the virtual machine.
        /// </summary>
        /// <param name="task">The cloud task to execute.</param>
        public void ExecuteTask(CloudTask task)
        {
            // Simulate task execution
            Console.WriteLine($"Executing CloudTask {task.TaskId} on VM {Id}");
            Thread.Sleep(task.Duration * 1000); // Simulate cloud task duration
            IsAvailable = true;
            Console.WriteLine($"CloudTask {task.TaskId} completed on VM {Id}");
        }
    }
}
