using CloudSim.Centers;
using CloudSim.Connections;
using CloudSim.Logic;
using CloudSim.Machines;
using CloudSim.Scheduling;

// Create a network
Network network = new("Global Network");

// Create data centers
DataCenter dc1 = new("Data Center 1");
DataCenter dc2 = new("Data Center 2");

// Add virtual machines to data centers
dc1.AddVirtualMachine(new VirtualMachine("VM1", 4, 8192));
dc2.AddVirtualMachine(new VirtualMachine("VM2", 8, 16384));

// Add data centers to network
network.AddDataCenter(dc1);
network.AddDataCenter(dc2);

// Create tasks
CloudTask task1 = new("Task1", 2, 4096, 60);
CloudTask task2 = new("Task2", 4, 8192, 120);

// Schedule tasks
network.ScheduleTask(task1);
network.ScheduleTask(task2);

// Create and run the simulation
CloudSimulation simulation = new(network);
simulation.RunSimulation();