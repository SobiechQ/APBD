using System;
using JetBrains.Annotations;
using LegacyApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LegacyApp.Tests;

[TestClass]
[TestSubject(typeof(UserService))]
public class UserServiceTest
{

    [TestMethod]
    public void ShouldReturnFalseWhenFirstNameIsEmpty()
    {
        //sekcje
        var service = new UserService();
        //arażacji, zależności do testowania

        var b = service.AddUser("", "dwa", "a@gmail.com", DateTime.Now, 20);
        //działania, wywołujemy
        
        //sprawdzenia, sprawdzamy wynik
        Assert.AreEqual(true, b);
    }

    [TestMethod]
    public void ShouldReturnFalseWhenParametersNull()
    {
        //sekcje
        var service = new UserService();
        //arażacji, zależności do testowania

        var b = service.AddUser(null, "dwa", "a@gmail.com", DateTime.Now, 20);
        //działania, wywołujemy
        
        //sprawdzenia, sprawdzamy wynik
        Assert.AreEqual(false, b);
    }
}