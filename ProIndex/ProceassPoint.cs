using System;
using System.Linq;
using ProIndex.Models;

namespace ProIndex
{
    public class ProceassPoint
    {

        public double? HowLong(double? value, double length1, double length2, double length3, double length4, double length5)
        {
            if (value.HasValue)
            {
                if (value > 0 && value <= length1)
                {
                    return 0 + ((value - 0) * ((1 - 0) / (length1 - 0)));
                }
                else if (value > length1 && value <= length2)
                {
                    return 1 + ((value - length1) * ((2 - 1) / (length2 - length1)));
                }
                else if (value > length2 && value <= length3)
                {
                    return 2 + ((value - length2) * ((3 - 2) / (length3 - length2)));
                }
                else if (value > length3 && value <= length3)
                {
                    return 3 + ((value - length3) * ((4 - 3) / (length4 - length3)));
                }
                else if (value > length4 && value <= length5)
                {
                    return 4 + ((value - length4) * ((5 - 4) / (length5 - length4)));
                }
                else
                {
                    return 5;
                }
            }
            else
            {
                return null;
            }
        }

        public double? HowFar(double? value, double length1, double length2, double length3, double length4, double length5)
        {
            if (value.HasValue)
            {
                if (value <= length1 && value >= length2)
                {
                    return 1 + ((length2 - value) * ((0 - 1) / (length2 - length1)));
                }
                else if (value < length2 && value >= length3)
                {
                    return 2 + ((length3 - value) * ((1 - 2) / (length3 - length2)));
                }
                else if (value < length3 && value >= length4)
                {
                    return 3 + ((length4 - value) * ((2 - 3) / (length4 - length3)));
                }
                else if (value < length4 && value >= length5)
                {
                    return 4 + ((length5 - value) * ((3 - 4) / (length5 - length4)));
                }
                else if (value < length5 && value >= 0)
                {
                    return 5 + ((value - length4) * ((4 - 5) / (length5 - length4)));
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return null;
            }
        }

        public double? HowLive(double? value)
        {
            if (value.HasValue)
            {
                if (value <= 7)
                {
                    return 0;
                }
                if (value == 8)
                {
                    return 1;
                }
                if (value == 9)
                {
                    return 2;
                }
                if (value == 10)
                {
                    return 3;
                }
                if (value == 11)
                {
                    return 4;
                }
                if (value == 12)
                {
                    return 5;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public string QualityWater(string value)
        {
            switch (value)
            {
                case "เสื่อมโทรมมาก": return "1";
                case "เสื่อมโทรม": return "2";
                case "พอใช้": return "3";
                case "ดี": return "4";
                default: return "5";
            }
        }

        public AllIndex Procress(AllIndex item)
        {
            var create = new AllIndex
            {
                _id = item._id,
                REG = item.REG,
                REG_NAME = item.REG_NAME,
                CWT = item.CWT,
                CWT_NAME = item.CWT_NAME,
                AMP = item.AMP,
                AMP_NAME = item.AMP_NAME,
                TAM = item.TAM,
                TAM_NAME = item.TAM_NAME,
                RainEveryYear = HowLong(item.RainEveryYear, 500, 800, 1200, 2000, 2400),
                RainEveryYearPerPopulation = HowLong(item.RainEveryYearPerPopulation, 1000, 1700, 3000, 5000, 10000),
                GroundWaterEveryYearPerPopulation = HowLong(item.GroundWaterEveryYearPerPopulation, 500, 1000, 1700, 3000, 5000),
                WaterStoreEveryYearPerPopulation = HowLong(item.WaterStoreEveryYearPerPopulation, 500, 1000, 1700, 3000, 5000),
                WaterStorePerWaterfront = HowLong(item.WaterStorePerWaterfront, 5, 10, 20, 30, 40),
                GroundWaterImprovePerPopulation = HowLong(item.GroundWaterImprovePerPopulation, 25, 50, 70, 100, 150),
                QualitySurfaceWater = QualityWater(item.QualitySurfaceWater),
                QualityGroundWater = HowLong(item.QualityGroundWater, 5, 6, 7, 8, 9),
                HouseHoldHavePlumpingPerAllHouseHold = HowLong(item.HouseHoldHavePlumpingPerAllHouseHold, 20, 40, 60, 80, 100),
                HouseHoldInCityHavePlumpingPerAllHouseHold = HowLong(item.HouseHoldInCityHavePlumpingPerAllHouseHold, 20, 40, 60, 80, 100),
                GovernmentHasPumping = HowLong(item.GovernmentHasPumping, 20, 40, 60, 80, 100),
                HouseholdHasGoodPumping = HowLong(item.HouseholdHasGoodPumping, 20, 40, 60, 80, 100),
                ConsumptionOfWater = HowLong(item.ConsumptionOfWater, 20, 30, 50, 70, 100), //check it again
                GovernmentHasGoodPumping = HowLong(item.GovernmentHasGoodPumping, 20, 40, 60, 80, 100),
                TimeHasPumpingPerYear = HowLong(item.TimeHasPumpingPerYear, 10, 10.5, 11, 11.5, 12),
                AreaOfIrrigationPerAreaOfAgriculture = HowLong(item.AreaOfIrrigationPerAreaOfAgriculture, 10, 20, 30, 40, 50),
                HouseholdHasAgricultureInIrrigation = HowLong(item.HouseholdHasAgricultureInIrrigation, 20, 40, 60, 80, 100),
                ReservoirPerAreaOfAgriculture = item.ReservoirPerAreaOfAgriculture <= 200 ? 0 : HowLong(item.ReservoirPerAreaOfAgriculture, 800, 1200, 1600, 2000, 3000),
                WaterUsageForAgriculture = item.WaterUsageForAgriculture <= 2 ? 0 : HowLong(item.WaterUsageForAgriculture, 1000, 2500, 5000, 10000, 20000),
                WaterQualityForAgriculture = QualityWater(item.WaterQualityForAgriculture),
                WaterUsageForFactory = item.WaterUsageForFactory <= 350 ? 0 : HowLong(item.WaterUsageForFactory, 4000, 7500, 65000, 180000, 290000),
                WaterQualityForFactory = HowLong(item.WaterQualityForFactory, 20, 40, 60, 80, 100),
                WaterUsageForSurvice = item.WaterUsageForSurvice <= 900 ? 0 : HowLong(item.WaterUsageForSurvice, 4000, 7000, 20000, 40000, 60000),
                WaterQualitySurvice = HowLong(item.WaterQualitySurvice, 20, 40, 60, 80, 100),
                WaterBalanceCostAndWaterUse = HowLong(item.WaterBalanceCostAndWaterUse, 50, 67, 100, 150, 200),
                FactoryHasTreatmentSystem = HowLong(item.FactoryHasTreatmentSystem, 20, 40, 60, 80, 100),
                AreaOfHouseholdPerAllAreaInCity = HowFar(item.AreaOfHouseholdPerAllAreaInCity, 100, 80, 60, 40, 20),
                CommunityHasTreatmentSystemPerAllCommunity = HowLong(item.CommunityHasTreatmentSystemPerAllCommunity, 20, 40, 60, 80, 100),
                WaterSourceQualityGoodByWQI = item.WaterSourceQualityGoodByWQI < 20 ? 0 : HowLong(item.WaterSourceQualityGoodByWQI, 50, 60, 70, 80, 90),
                TimePeriodWaterBalance = HowLive(item.TimePeriodWaterBalance),
                DensityOfWaterQualityMonitoringSystem = item.DensityOfWaterQualityMonitoringSystem < 0.005 ? 0 : HowLong(item.DensityOfWaterQualityMonitoringSystem, 0.01, 0.02, 0.05, 0.07, 0.1),
                IndustrialDensity = item.IndustrialDensity > 0.15 ? 0 : HowFar(item.IndustrialDensity, 0.15, 0.1, 0.05, 0.02, 0.01),
                IndustrialHasWastewaterPerAllIndustrial = HowFar(item.IndustrialHasWastewaterPerAllIndustrial, 100, 80, 60, 40, 20),
                CostOfFloodPerAllArea = item.CostOfFloodPerAllArea > 90000 ? 0 : HowFar(item.CostOfFloodPerAllArea, 90000, 59000, 25000, 5500, 2800),
                RepeatedFloodAreasPerArea = item.RepeatedFloodAreasPerArea == 100 ? 0 : HowFar(item.RepeatedFloodAreasPerArea, 100, 80, 60, 40, 20),
                AreHasChanceOfLandslidesPerArea = item.AreHasChanceOfLandslidesPerArea == 100 ? 0 : HowFar(item.AreHasChanceOfLandslidesPerArea, 100, 80, 60, 40, 20),
                PopulationInFloodAreaPerPopulation = item.PopulationInFloodAreaPerPopulation == 100 ? 0 : HowFar(item.PopulationInFloodAreaPerPopulation, 100, 80, 60, 40, 20),
                TransportationFloodedAreas = item.TransportationFloodedAreas >= 1.5 ? 5 : HowLong(item.TransportationFloodedAreas, 0.2, 0.5, 0.75, 1, 1.5),
                AreaOfFloodPerAreaIncity = item.AreaOfFloodPerAreaIncity == 100 ? 0 : HowFar(item.AreaOfFloodPerAreaIncity, 100, 80, 60, 40, 20),
                PeriodOfFlooding = item.PeriodOfFlooding > 168 ? 0 : HowFar(item.PeriodOfFlooding, 168, 120, 48, 24, 2),
                DepthOfFlood = item.DepthOfFlood > 3 ? 0 : HowFar(item.DepthOfFlood, 3, 1, 0.5, 0.3, 0.1),
                VillagesWarningPerVillages = item.VillagesWarningPerVillages == 100 ? 5 : HowLong(item.VillagesWarningPerVillages, 20, 40, 60, 80, 100),
                CostDroughtPerYearPerArea = item.CostDroughtPerYearPerArea > 25000 ? 0 : item.CostDroughtPerYearPerArea < 1500 ? 5 : HowFar(item.CostDroughtPerYearPerArea, 25000, 19000, 11000, 6000, 4000),
                RepeatedDroughtAreasPerEntire = item.RepeatedDroughtAreasPerEntire == 100 ? 0 : HowFar(item.RepeatedDroughtAreasPerEntire, 100, 80, 60, 40, 20),
                AgriculturalAreaInRepeatedDrought = item.AgriculturalAreaInRepeatedDrought == 100 ? 0 : HowFar(item.AgriculturalAreaInRepeatedDrought, 100, 80, 60, 40, 20),
                ForestAreaPerArea = item.ForestAreaPerArea == 100 ? 5 : HowLong(item.ForestAreaPerArea, 20, 40, 60, 80, 100),
                NDVI = HowLong(item.NDVI, 0.3, 0.4, 0.5, 0.6, 0.8),
                ConserveAndManage = item.ConserveAndManage > 2500 ? 0 : HowFar(item.ConserveAndManage, 2500, 1500, 700, 300, 150),
                PlanWaterManagement = item.PlanWaterManagement > 1200 ? 0 : HowFar(item.PlanWaterManagement, 1200, 750, 500, 300, 200),
                ParticipatingIrrigationProjects = HowLong(item.ParticipatingIrrigationProjects, 20, 40, 60, 80, 100),
                DistributionOfParticipatingIrrigationProjects = item.ParticipatingIrrigationProjects > 15000 ? 0 : item.ParticipatingIrrigationProjects < 2000 ? 5 : HowFar(item.ParticipatingIrrigationProjects, 15000, 7000, 5000, 4000, 3000),
                GPPPerWaterCost = item.GPPPerWaterCost > 700 ? 5 : item.GPPPerWaterCost < 3 ? 0 : HowLong(item.GPPPerWaterCost, 3, 7, 10, 120, 330),
                GPPPerPopulation = item.GPPPerPopulation < 80000 ? 0 : HowLong(item.GPPPerPopulation, 80000, 110000, 150000, 300000, 500000),
                WorkingAgePerPopulation = HowLong(item.WorkingAgePerPopulation, 20, 40, 60, 80, 100),
                ResearchOnWaterResourcesManagement = item.ResearchOnWaterResourcesManagement > 100 ? 0 : HowFar(item.ResearchOnWaterResourcesManagement, 100, 80, 60, 40, 20),
                WaterwaysAreSuitableForWaterTransportation = HowLong(item.WaterStoreEveryYearPerPopulation, 20, 40, 60, 80, 100),
                CoverageMonitoringSystem = item.CoverageMonitoringSystem < 20 ? 5 : item.CoverageMonitoringSystem > 150 ? 0 : HowFar(item.CoverageMonitoringSystem, 150, 120, 90, 60, 40),
                GoodCoverageMonitoringSystem = HowLong(item.GoodCoverageMonitoringSystem, 20, 40, 60, 80, 100),
                ReservoirHasGoodManagement = HowLong(item.ReservoirHasGoodManagement, 20, 40, 60, 80, 100)

            };
            throw new NotImplementedException();
        }
    }
}
