using Microsoft.VisualStudio.TestTools.UnitTesting;
using marsRover.Interfaces;
using System.Collections.Generic;
using marsRover.Dtos;
using marsRover.Enums;
using marsRover.Entities;
using marsRover.Services;
using AutoMapper;
using Moq;
using marsRover.Helpers;
using Newtonsoft.Json;

namespace marsRoverUnitTest
{
    [TestClass]
    public class RoversServiceShouldBeSuccess
    {
        [TestMethod]
        public void TestExecuteTheRoversMissionWith1_2_N_LMLMLMLMM()
        {
            // var mapper = new Mock<IMapper>();
            var config = new MapperConfiguration(cfg => { 
                cfg.AddProfile<MappingProfile>();
            });
            IMapper mapper = config.CreateMapper();
            // IMapper mapper;
            var roverService = new RoverService(mapper);
            // Arrange
            List<RoverDto> roverDtos = new List<RoverDto>
            {
                new RoverDto {X = 1, Y = 2, Direction = CompassDirection.N, Instructions = "LMLMLMLMM"}
            };

            List<Rover> expectedRovers = new List<Rover>
            {
                new Rover {X = 1, Y = 3, Direction = CompassDirection.N}
            };
            var expectedRoversJson = JsonConvert.SerializeObject(expectedRovers);

            // Act
            List<Rover> actRovers = roverService.ExecuteTheMission(roverDtos);
            var actRoversJson = JsonConvert.SerializeObject(actRovers);

            // Assert
            Assert.AreEqual(expectedRoversJson, actRoversJson);
        }

        [TestMethod]
        public void TestExecuteTheRoversMissionWith3_3_E_MMRMMRMRRM()
        {
            // var mapper = new Mock<IMapper>();
            var config = new MapperConfiguration(cfg => { 
                cfg.AddProfile<MappingProfile>();
            });
            IMapper mapper = config.CreateMapper();
            // IMapper mapper;
            var roverService = new RoverService(mapper);
            // Arrange
            List<RoverDto> roverDtos = new List<RoverDto>
            {
                new RoverDto {X = 3, Y = 3, Direction = CompassDirection.E, Instructions = "MMRMMRMRRM"}
            };

            List<Rover> expectedRovers = new List<Rover>
            {
                new Rover {X = 5, Y = 1, Direction = CompassDirection.E}
            };
            var expectedRoversJson = JsonConvert.SerializeObject(expectedRovers);

            // Act
            List<Rover> actRovers = roverService.ExecuteTheMission(roverDtos);
            var actRoversJson = JsonConvert.SerializeObject(actRovers);

            // Assert
            Assert.AreEqual(expectedRoversJson, actRoversJson);
        }
    }
}
