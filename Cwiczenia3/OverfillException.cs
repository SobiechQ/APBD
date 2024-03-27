using System.Transactions;

namespace ConsoleApp1;

public class OverfillException(string message) : Exception(message);