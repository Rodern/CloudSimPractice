namespace CloudSim.Scheduling
{
    /// <summary>
    /// Represents a cloud task in the cloud simulation.
    /// </summary>
    public class CloudTask
    {
        /// <summary>
        /// Gets or sets the ID of the cloud task.
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the required CPU cores for the cloud task.
        /// </summary>
        public int RequiredCpuCores { get; set; }

        /// <summary>
        /// Gets or sets the required memory for the cloud task in MB.
        /// </summary>
        public int RequiredMemory { get; set; }

        /// <summary>
        /// Gets or sets the duration of the cloud task in seconds.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudTask"/> class.
        /// </summary>
        /// <param name="taskId">The ID of the cloud task.</param>
        /// <param name="requiredCpuCores">The required CPU cores.</param>
        /// <param name="requiredMemory">The required memory in MB.</param>
        /// <param name="duration">The duration in seconds.</param>
        public CloudTask(string taskId, int requiredCpuCores, int requiredMemory, int duration)
        {
            TaskId = taskId;
            RequiredCpuCores = requiredCpuCores;
            RequiredMemory = requiredMemory;
            Duration = duration;
        }
    }
}
