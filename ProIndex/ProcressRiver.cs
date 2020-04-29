using ProIndex.Models;
using System;

namespace ProIndex
{
    public class ProcressRiver
    {
        public double? CalPercent(double item, double? data)
        {
            return (item * 100) / data;
        }

        public River Procress(River item, AllIndex dataRiver)
        {
            var create = new River
            {
                _id = item._id,
                RIVERCODE = item.RIVERCODE,
                REG = item.REG,
                REG_NAME = item.REG_NAME,
                CWT = item.CWT,
                CWT_NAME = item.CWT_NAME,
                AMP = item.AMP,
                AMP_NAME = item.AMP_NAME,
                TAM = item.TAM,
                TAM_NAME = item.TAM_NAME,
                AREA = item.AREA,
                PERCEN = item.PERCEN,
                RIVER = item.RIVER,
                SUBRIVER = item.SUBRIVER,
                RainEveryYear = CalPercent(item.PERCEN, dataRiver.RainEveryYear),
                RainEveryYearPerPopulation = CalPercent(item.PERCEN, dataRiver.RainEveryYearPerPopulation),
                GroundWaterEveryYearPerPopulation = CalPercent(item.PERCEN, dataRiver.GroundWaterEveryYearPerPopulation),
                WaterStoreEveryYearPerPopulation = CalPercent(item.PERCEN, dataRiver.WaterStoreEveryYearPerPopulation),
                WaterStorePerWaterfront = CalPercent(item.PERCEN, dataRiver.WaterStorePerWaterfront),
                GroundWaterImprovePerPopulation = CalPercent(item.PERCEN, dataRiver.GroundWaterImprovePerPopulation),
                QualitySurfaceWater = null,
                // item.TypeOfSurFaceWaterByWQI,
                QualityGroundWater = CalPercent(item.PERCEN, dataRiver.QualityGroundWater),
                HouseHoldHavePlumpingPerAllHouseHold = CalPercent(item.PERCEN, dataRiver.HouseHoldHavePlumpingPerAllHouseHold),
                HouseHoldInCityHavePlumpingPerAllHouseHold = CalPercent(item.PERCEN, dataRiver.HouseHoldInCityHavePlumpingPerAllHouseHold),
                GovernmentHasPumping = CalPercent(item.PERCEN, dataRiver.GovernmentHasPumping),
                HouseholdHasGoodPumping = CalPercent(item.PERCEN, dataRiver.HouseholdHasGoodPumping),
                ConsumptionOfWater = CalPercent(item.PERCEN, dataRiver.ConsumptionOfWater),
                GovernmentHasGoodPumping = CalPercent(item.PERCEN, dataRiver.GovernmentHasGoodPumping),
                TimeHasPumpingPerYear = CalPercent(item.PERCEN, dataRiver.TimeHasPumpingPerYear),
                AreaOfIrrigationPerAreaOfAgriculture = CalPercent(item.PERCEN, dataRiver.AreaOfIrrigationPerAreaOfAgriculture),
                HouseholdHasAgricultureInIrrigation = CalPercent(item.PERCEN, dataRiver.HouseholdHasAgricultureInIrrigation),
                ReservoirPerAreaOfAgriculture = CalPercent(item.PERCEN, dataRiver.ReservoirPerAreaOfAgriculture),
                WaterUsageForAgriculture = CalPercent(item.PERCEN, dataRiver.WaterUsageForAgriculture),
                WaterQualityForAgriculture = null,
                // item.TypeOfSurFaceWaterByWQI,
                WaterUsageForFactory = CalPercent(item.PERCEN, dataRiver.WaterUsageForFactory),
                WaterQualityForFactory = CalPercent(item.PERCEN, dataRiver.WaterQualityForFactory),
                WaterUsageForSurvice = CalPercent(item.PERCEN, dataRiver.WaterUsageForSurvice),
                WaterQualitySurvice = CalPercent(item.PERCEN, dataRiver.WaterQualitySurvice),
                WaterBalanceCostAndWaterUse = CalPercent(item.PERCEN, dataRiver.WaterBalanceCostAndWaterUse),
                FactoryHasTreatmentSystem = CalPercent(item.PERCEN, dataRiver.FactoryHasTreatmentSystem),
                AreaOfHouseholdPerAllAreaInCity = CalPercent(item.PERCEN, dataRiver.AreaOfHouseholdPerAllAreaInCity),
                CommunityHasTreatmentSystemPerAllCommunity = CalPercent(item.PERCEN, dataRiver.CommunityHasTreatmentSystemPerAllCommunity),
                WaterSourceQualityGoodByWQI = CalPercent(item.PERCEN, dataRiver.WaterSourceQualityGoodByWQI),
                TimePeriodWaterBalance = CalPercent(item.PERCEN, dataRiver.TimePeriodWaterBalance),
                DensityOfWaterQualityMonitoringSystem = CalPercent(item.PERCEN, dataRiver.DensityOfWaterQualityMonitoringSystem),
                IndustrialDensity = CalPercent(item.PERCEN, dataRiver.IndustrialDensity),
                IndustrialHasWastewaterPerAllIndustrial = CalPercent(item.PERCEN, dataRiver.IndustrialHasWastewaterPerAllIndustrial),
                CostOfFloodPerAllArea = CalPercent(item.PERCEN, dataRiver.CostOfFloodPerAllArea),
                RepeatedFloodAreasPerArea = CalPercent(item.PERCEN, dataRiver.RepeatedFloodAreasPerArea),
                AreHasChanceOfLandslidesPerArea = CalPercent(item.PERCEN, dataRiver.AreHasChanceOfLandslidesPerArea),
                PopulationInFloodAreaPerPopulation = CalPercent(item.PERCEN, dataRiver.PopulationInFloodAreaPerPopulation),
                TransportationFloodedAreas = CalPercent(item.PERCEN, dataRiver.TransportationFloodedAreas),
                AreaOfFloodPerAreaIncity = CalPercent(item.PERCEN, dataRiver.AreaOfFloodPerAreaIncity),
                PeriodOfFlooding = CalPercent(item.PERCEN, dataRiver.PeriodOfFlooding),
                DepthOfFlood = CalPercent(item.PERCEN, dataRiver.DepthOfFlood),
                VillagesWarningPerVillages = CalPercent(item.PERCEN, dataRiver.VillagesWarningPerVillages),
                CostDroughtPerYearPerArea = CalPercent(item.PERCEN, dataRiver.CostDroughtPerYearPerArea),
                RepeatedDroughtAreasPerEntire = CalPercent(item.PERCEN, dataRiver.RepeatedDroughtAreasPerEntire),
                AgriculturalAreaInRepeatedDrought = CalPercent(item.PERCEN, dataRiver.AgriculturalAreaInRepeatedDrought),
                ForestAreaPerArea = CalPercent(item.PERCEN, dataRiver.ForestAreaPerArea),
                NDVI = CalPercent(item.PERCEN, dataRiver.NDVI),
                // IF(CH3>0,item.AreaOfSubdistrict/CH3,IF(CH3=0,0)),
                // item.ForestManagementCompany>0,item.AreaOfSubdistrict/item.ForestManagementCompany,IF(item.ForestManagementCompany=0,0)
                ConserveAndManage = CalPercent(item.PERCEN, dataRiver.ConserveAndManage),
                PlanWaterManagement = CalPercent(item.PERCEN, dataRiver.PlanWaterManagement),
                ParticipatingIrrigationProjects = CalPercent(item.PERCEN, dataRiver.ParticipatingIrrigationProjects),
                DistributionOfParticipatingIrrigationProjects = CalPercent(item.PERCEN, dataRiver.DistributionOfParticipatingIrrigationProjects),
                GPPPerWaterCost = CalPercent(item.PERCEN, dataRiver.GPPPerWaterCost),
                GPPPerPopulation = CalPercent(item.PERCEN, dataRiver.GPPPerPopulation),
                WorkingAgePerPopulation = CalPercent(item.PERCEN, dataRiver.WorkingAgePerPopulation),
                ResearchOnWaterResourcesManagement = CalPercent(item.PERCEN, dataRiver.ResearchOnWaterResourcesManagement),
                WaterwaysAreSuitableForWaterTransportation = CalPercent(item.PERCEN, dataRiver.WaterwaysAreSuitableForWaterTransportation),
                CoverageMonitoringSystem = CalPercent(item.PERCEN, dataRiver.CoverageMonitoringSystem),
                GoodCoverageMonitoringSystem = CalPercent(item.PERCEN, dataRiver.GoodCoverageMonitoringSystem),
                ReservoirHasGoodManagement = CalPercent(item.PERCEN, dataRiver.ReservoirHasGoodManagement),
            };
            return create;
        }
    }
}