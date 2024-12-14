# CloudSimPractice

CloudSimPractice is a cloud computing simulation framework written in C#. It allows users to simulate cloud computing environments, including data centers, virtual machines, and task scheduling.

## Features

- Simulate data centers and virtual machines
- Allocate resources to tasks
- Schedule and execute tasks
- Simple and extensible architecture

## Getting Started

### Prerequisites

- .NET SDK (version 8.0 or later)

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/rodern/CloudSimPractice.git
   cd CloudSimPractice
   ```

2. Build the project:
   ```sh
   dotnet build
   ```

### Usage

1. Create a network:
   ```csharp
   Network network = new Network("Global Network");
   ```

2. Create data centers:
   ```csharp
   DataCenter dc1 = new DataCenter("Data Center 1");
   DataCenter dc2 = new DataCenter("Data Center 2");
   ```

3. Add virtual machines to data centers:
   ```csharp
   dc1.AddVirtualMachine(new VirtualMachine("VM1", 4, 8192));
   dc2.AddVirtualMachine(new VirtualMachine("VM2", 8, 16384));
   ```

4. Add data centers to network:
   ```csharp
   network.AddDataCenter(dc1);
   network.AddDataCenter(dc2);
   ```

5. Create and run the simulation:
   ```csharp
   CloudSimulation simulation = new CloudSimulation(network);

   // Create tasks
   CloudTask task1 = new("Task1", 2, 4096, 60);
   CloudTask task2 = new("Task2", 4, 8192, 120);

   // Add tasks to simulation
   simulation.AddTask(task1);
   simulation.AddTask(task2);

   // Run the simulation
   simulation.RunSimulation();
   ```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.

## Acknowledgments

- Inspired by CloudSim, a cloud computing simulation framework written in Java.
```