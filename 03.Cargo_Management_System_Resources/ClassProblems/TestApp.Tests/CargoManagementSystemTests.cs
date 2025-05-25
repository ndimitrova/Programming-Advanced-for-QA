using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

[TestFixture]
public class CargoManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyCargoCollectionAndCount()
    {
        // Arrange & Act

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();


        // Assert

        Assert.IsEmpty(cargoManagementSystem.GetAllCargos());
        Assert.AreEqual(0, cargoManagementSystem.CargoCount);

    }

    [Test]
    public void Test_AddCargo_ValidCargoName_AddNewCargo()
    {
        // Arrange

        string cargo = "luggage";
        List<string> cargos = new List<string>() { "luggage" };

        // Act

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();
        cargoManagementSystem.AddCargo(cargo);
        List<string> result = cargoManagementSystem.GetAllCargos();


        //Assert

        Assert.AreEqual(cargos, result);
    }

    [Test]
    public void Test_AddCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();

        //Assert

        Assert.Throws<ArgumentException>(() => cargoManagementSystem.AddCargo(null));


        //Assert

        Assert.Throws<ArgumentException>(() => cargoManagementSystem.AddCargo(string.Empty));
    }

    [Test]
    public void Test_RemoveCargo_ValidCargoName_RemoveFirstCargoName()
    {
        // Arrange

        string cargo1 = "luggage";
        string cargo2 = "cars";
        List<string> cargos = new List<string>() { "cars" };

        //Act

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();
        cargoManagementSystem.AddCargo(cargo1);
        cargoManagementSystem.AddCargo(cargo2);
        cargoManagementSystem.RemoveCargo(cargo1);


        List<string> result = cargoManagementSystem.GetAllCargos();

        //Assert
        Assert.AreEqual(cargos, result);

    }

    [Test]
    public void Test_RemoveCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        //Arrange 

        string cargo1 = "luggage";
        string cargo2 = "cars";

        // Act

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();
        cargoManagementSystem.AddCargo(cargo1);
        cargoManagementSystem.AddCargo(cargo2);

        //Assert

        Assert.Throws<ArgumentException>(() => cargoManagementSystem.RemoveCargo(null));

        //Assert

        Assert.Throws<ArgumentException>(() => cargoManagementSystem.RemoveCargo(string.Empty));
    }

    [Test]
    public void Test_GetAllCargos_AddedAndRemovedCargos_ReturnsExpectedCargoCollection()
    {
        // Arrange

        string cargo1 = "luggage";
        string cargo2 = "cars";
        string cargo3 = "trucks";
        string cargo4 = "containers";
        string cargo5 = "chemicals";


        List<string> cargos = new List<string>() { "cars", "trucks", "chemicals" };

        //Act

        CargoManagementSystem cargoManagementSystem = new CargoManagementSystem();
        cargoManagementSystem.AddCargo(cargo1);
        cargoManagementSystem.AddCargo(cargo2);
        cargoManagementSystem.AddCargo(cargo3);
        cargoManagementSystem.AddCargo(cargo4);
        cargoManagementSystem.RemoveCargo(cargo1);
        cargoManagementSystem.RemoveCargo(cargo4);
        cargoManagementSystem.AddCargo(cargo5);


        List<string> result = cargoManagementSystem.GetAllCargos();

        //Assert
        Assert.AreEqual(cargos, result);

    }
}

    