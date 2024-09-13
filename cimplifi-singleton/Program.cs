// See https://aka.ms/new-console-template for more information
using cimplifi_singleton;

Singleton instance1 = Singleton.GetInstance();
Singleton instance2 = Singleton.GetInstance();

if (ReferenceEquals(instance1, instance2))
{
    Console.WriteLine($"Both instances {instance1} and {instance2} are equal.");
}

instance1.ShowMessage();
