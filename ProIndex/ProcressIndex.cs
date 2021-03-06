using System;
using System.Linq;
using ProIndex.Models;


namespace ProIndex
{
    public class ProcressIndex
    {
        public AllIndex Propcress(SurveyAndCompany item)
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
                RainEveryYear = item.RainPerYear,
                RainEveryYearPerPopulation = item.SurfaceWaterPerYear / item.CountPopulation * 1000000,
                GroundWaterEveryYearPerPopulation = item.RefillGroundWaterPerYear / item.CountPopulation * 1000000,
                WaterStoreEveryYearPerPopulation = item.ReservoirHasAllocate / item.CountPopulation * 1000000,
                WaterStorePerWaterfront = item.CapacityOfReservoir / item.SurfaceWaterPerYear * 100,
                GroundWaterImprovePerPopulation = item.CubicMeterGroundWaterForUse / item.CountPopulation,
                QualitySurfaceWater = null,
                // item.TypeOfSurFaceWaterByWQI,
                QualityGroundWater = item.TDSOfGroundWater,
                HouseHoldHavePlumpingPerAllHouseHold = item.IsHouseHoldHasPlumbingCountryside / item.IsAllHouseHoldCountryside * 100,
                HouseHoldInCityHavePlumpingPerAllHouseHold = item.IsHouseHoldHasPlumbingDistrict / item.IsAllHouseHoldDistrict * 100,
                GovernmentHasPumping = item.IsGovernmentUsage / item.IsGovernment * 100,
                HouseholdHasGoodPumping = item.IsHouseHoldGoodPlumbing / item.IsHouseHold * 100,
                ConsumptionOfWater = ((item.CubicMeterPlumbingForDrink + item.CubicMeterGroundWaterForDrink + item.CountCommunity) * 1000) / item.CountPopulation / 365,
                GovernmentHasGoodPumping = item.IsGovernmentWaterQuality / item.IsGovernmentUsage * 100,
                TimeHasPumpingPerYear = item.HasntPlumbing,
                AreaOfIrrigationPerAreaOfAgriculture = ((item.FieldCommunity * 1600 / 1000000) + item.AreaOfAgricultureHasIrrigation) / item.AreaOfAgriculture * 100,
                HouseholdHasAgricultureInIrrigation = item.IsAgricultureHasIrrigationField / item.IsAgriculture * 100,
                ReservoirPerAreaOfAgriculture = item.CapacityOfReservoir * 1000000 / (item.AreaOfAgriculture * 1000000 / 1600),
                WaterUsageForAgriculture = (item.GPPOfAgricultureInProvince * 1000000) / (item.CubicMeterGroundWaterForAgriculture + item.CubicMeterPlumbingForAgriculture + item.CubicMeterSurfaceForAgriculture),
                WaterQualityForAgriculture = null,
                // item.TypeOfSurFaceWaterByWQI,
                WaterUsageForFactory = item.GPPOfCommercialInProvince * 1000000 / (item.CubicMeterGroundWaterForProduct + item.CubicMeterPlumbingForProduct + item.CubicMeterSurfaceForProduct),
                WaterQualityForFactory = item.IsFactorialWaterQuality / item.IsAllFactorial * 100,
                WaterUsageForSurvice = (item.GPPOfServiceInProvince * 1000000) / (item.CubicMeterGroundWaterForService + item.CubicMeterPlumbingForService + item.CubicMeterSurfaceForService),
                WaterQualitySurvice = item.IsCommercialWaterQuality / item.IsAllCommercial * 100,
                WaterBalanceCostAndWaterUse = ((item.CapacityOfReservoir + item.SurfaceWaterPerYear + item.RefillGroundWaterPerYear) * 1000000) / (item.CubicMeterGroundWaterForAgriculture + item.CubicMeterGroundWaterForService + item.CubicMeterGroundWaterForProduct + item.CubicMeterGroundWaterForDrink + item.CubicMeterPlumbingForAgriculture + item.CubicMeterPlumbingForService + item.CubicMeterPlumbingForProduct + item.CubicMeterPlumbingForDrink + item.CubicMeterSurfaceForAgriculture + item.CubicMeterSurfaceForService + item.CubicMeterSurfaceForProduct + item.CubicMeterSurfaceForDrink + (item.WaterOfPreservingEcosystem * 1000000)) * 100,
                FactoryHasTreatmentSystem = item.IndustryHasWasteWaterTreatment / item.IsFactorial * 100,
                AreaOfHouseholdPerAllAreaInCity = item.AreaOfCity / item.AreaOfSubdistrict * 100,
                CommunityHasTreatmentSystemPerAllCommunity = item.IsCommunityWaterManagementHasWaterTreatment / item.CountCommunity * 100,
                WaterSourceQualityGoodByWQI = item.HasMeasurementWQIOverSixOne / item.MeasurementWQI * 100,
                TimePeriodWaterBalance = item.MonthPreservingEcosystems,
                DensityOfWaterQualityMonitoringSystem = item.WaterTrackingStation / item.AreaOfSubdistrict,
                IndustrialDensity = item.IsFactorial / item.AreaOfSubdistrict,
                IndustrialHasWastewaterPerAllIndustrial = item.IndustryHasWasteWaterTreatment / item.IsFactorial * 100,
                CostOfFloodPerAllArea = item.DamageCostOfFloodPerYear / item.AreaOfReg,
                RepeatedFloodAreasPerArea = item.AreaHasChanceFlood / item.AreaOfSubdistrict * 100,
                AreHasChanceOfLandslidesPerArea = item.AreaHasChanceLandSlide / item.AreaOfSubdistrict * 100,
                PopulationInFloodAreaPerPopulation = item.PeopleInFloodedArea / item.CountPopulation * 100,
                TransportationFloodedAreas = item.LengthOfRoadInAreaOfFlood / item.AreaHasChanceFlood,
                AreaOfFloodPerAreaIncity = item.AreaOfCityHasFlood / item.AreaOfCity * 100,
                PeriodOfFlooding = item.TimeWaterHeightCm,
                DepthOfFlood = item.AvgWaterHeightCm,
                VillagesWarningPerVillages = item.CommunityNatureDisaster / item.CountCommunityHasDisaster * 100,
                CostDroughtPerYearPerArea = item.DamageCostOfDroughtPerYear / item.AreaOfReg,
                RepeatedDroughtAreasPerEntire = item.AreaHasChanceDrought / item.AreaOfSubdistrict * 100,
                AgriculturalAreaInRepeatedDrought = item.AreaOfAgricultureInDrought / item.AreaOfAgriculture * 100,
                ForestAreaPerArea = item.AreaOfForest / item.AreaOfSubdistrict * 100,
                NDVI = item.IndexOfPlant,
                // IF(CH3>0,item.AreaOfSubdistrict/CH3,IF(CH3=0,0)),
                // item.ForestManagementCompany>0,item.AreaOfSubdistrict/item.ForestManagementCompany,IF(item.ForestManagementCompany=0,0)
                ConserveAndManage = item.ForestManagementCompany > 0 ? item.AreaOfSubdistrict / item.ForestManagementCompany : 0,
                PlanWaterManagement = item.PlanOfWaterManagrmentInArea,
                ParticipatingIrrigationProjects = item.IrrigationProjectHasParticipate / item.IrrigationProject * 100,
                DistributionOfParticipatingIrrigationProjects = item.WaterManagementCompany == 0 ? 0 : item.AreaOfReg / item.WaterManagementCompany,
                GPPPerWaterCost = (item.GPPOfProvince * 1000000) / ((item.CapacityOfReservoir + item.RefillGroundWaterPerYear + item.SurfaceWaterPerYear) * 1000000),
                GPPPerPopulation = item.GPPOfProvince * 1000000 / item.CountPopulation,
                WorkingAgePerPopulation = item.CountWorkingAge / item.CountPopulation * 100,
                ResearchOnWaterResourcesManagement = item.WaterResourcesManagementProject,
                WaterwaysAreSuitableForWaterTransportation = item.LengthOfMainRiverAppropriateToWaterTransport / item.LengthOfMainRiver * 100,
                CoverageMonitoringSystem = item.AreaOfSubdistrict / item.WaterTrackingStation,
                GoodCoverageMonitoringSystem = item.GoodWaterTrackingStation / item.WaterTrackingStation * 100,
                ReservoirHasGoodManagement = item.ReservoirHasAllocate / item.Reservoir * 100
            };

            return create;
        }
    }
}