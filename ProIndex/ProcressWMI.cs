using ProIndex.Models;
using System;
using System.Linq;

namespace ProIndex
{
    public class ProcressWMI
    {
        public WMI ProcressWater(AllIndex item)
        {
            var create = new WMI
            {
                HasWater = HasWater(item),
                WaterManagementForUse = WaterManagementForUse(item),
                Agriculture = Agriculture(item),
                Factory = Factory(item),
                Service = Service(item),
                WaterForDevelopment = (Agriculture(item) + Factory(item) + Service(item)) / 3,
                WaterBalanceCostAndUse = item.WaterBalanceCostAndWaterUse,
                WaterQualityAndEnvironmentalManagement = WaterQualityAndEnvironmentalManagement(item),
                Flood = Flood(item),
                Drought = Drought(item),
                WaterDisasterManagement = (Flood(item) + Drought(item)) / 2,
                WatershedForestManagement = WatershedForestManagement(item),
                BasinManagementPlans = item.PlanWaterManagement,
                ParticipationWaterManagement = item.ParticipatingIrrigationProjects,
                WaterManagementOrganization = item.DistributionOfParticipatingIrrigationProjects,
                DevelopmentPotential = DevelopmentPotential(item),
                MaintainingForWaterTransportation = item.WaterwaysAreSuitableForWaterTransportation,
                Tracking = Tracking(item),
                WaterAllocation = item.ReservoirHasGoodManagement,
                WaterResourcesManagement = (item.PlanWaterManagement + item.ParticipatingIrrigationProjects + item.DistributionOfParticipatingIrrigationProjects + DevelopmentPotential(item) + item.WaterwaysAreSuitableForWaterTransportation + Tracking(item) + item.ReservoirHasGoodManagement) / 7,
            };
            throw new NotImplementedException();
        }

        public double? HasWater(AllIndex item) => (item.RainEveryYear + item.RainEveryYearPerPopulation + item.GroundWaterEveryYearPerPopulation + item.WaterStoreEveryYearPerPopulation + item.WaterStorePerWaterfront + item.GroundWaterImprovePerPopulation + Convert.ToDouble(item.QualitySurfaceWater) + item.QualityGroundWater) / 8;

        public double? WaterManagementForUse(AllIndex item) => (item.HouseHoldHavePlumpingPerAllHouseHold + item.HouseHoldInCityHavePlumpingPerAllHouseHold + item.GovernmentHasPumping + item.HouseholdHasGoodPumping + item.ConsumptionOfWater + item.GovernmentHasGoodPumping + item.TimeHasPumpingPerYear) / 7;

        public double? Agriculture(AllIndex item) => (item.AreaOfIrrigationPerAreaOfAgriculture + item.HouseholdHasAgricultureInIrrigation + item.ReservoirPerAreaOfAgriculture + item.WaterUsageForAgriculture + Convert.ToDouble(item.WaterQualityForAgriculture)) / 5;

        public double? Factory(AllIndex item) => (item.WaterUsageForFactory + item.WaterQualityForFactory) / 2;

        public double? Service(AllIndex item) => (item.WaterUsageForSurvice + item.WaterQualitySurvice) / 2;

        public double? WaterQualityAndEnvironmentalManagement(AllIndex item) => (item.FactoryHasTreatmentSystem + item.AreaOfHouseholdPerAllAreaInCity + item.CommunityHasTreatmentSystemPerAllCommunity + item.WaterSourceQualityGoodByWQI + item.TimePeriodWaterBalance + item.DensityOfWaterQualityMonitoringSystem + item.IndustrialDensity + item.IndustrialHasWastewaterPerAllIndustrial) / 8;

        public double? Flood(AllIndex item) => (item.CostOfFloodPerAllArea + item.RepeatedFloodAreasPerArea + item.AreHasChanceOfLandslidesPerArea + item.PopulationInFloodAreaPerPopulation + item.TransportationFloodedAreas + item.AreaOfFloodPerAreaIncity + item.PeriodOfFlooding + item.DepthOfFlood + item.VillagesWarningPerVillages) / 9;

        public double? Drought(AllIndex item) => (item.CostDroughtPerYearPerArea + item.RepeatedDroughtAreasPerEntire + item.AgriculturalAreaInRepeatedDrought) / 3;

        public double? WatershedForestManagement(AllIndex item) => (item.ForestAreaPerArea + item.NDVI + item.ConserveAndManage) / 3;

        public double? DevelopmentPotential(AllIndex item) => (item.GPPPerWaterCost + item.GPPPerPopulation + item.WorkingAgePerPopulation + item.ResearchOnWaterResourcesManagement) / 4;

        public double? Tracking(AllIndex item) => (item.CoverageMonitoringSystem + item.GoodCoverageMonitoringSystem) / 2;
    }
}