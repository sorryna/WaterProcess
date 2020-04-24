using System;
using System.Linq;
using ProIndex.Models;


namespace ProIndex
{
    public class ProcressIndex
    {
        public void Propcress(SurveyAndCompany item)
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
                QualitySurfaceWater = item.TypeOfSurFaceWaterByWQI,
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
                WaterUsageForAgriculture = null,
                WaterQualityForAgriculture = DA3,
                WaterUsageForFactory = null,
                WaterQualityForFactory = item.IsFactorialWaterQuality / AU3*100,
                WaterUsageForSurvice = null,
                WaterQualitySurvice = L3/AV3*100,
                WaterBalanceCostAndWaterUse = ((BX3+BR3+BQ3)*1000000)/(AD3+AE3+AF3+AG3+AH3+AI3+AJ3+AK3+AL3+AM3+AN3+AO3+(BV3*1000000))*100,
                FactoryHasTreatmentSystem = AB3/P3*100,
                AreaOfHouseholdPerAllAreaInCity = AY3/AX3*100,
                CommunityHasTreatmentSystemPerAllCommunity = R3/AQ3*100,
                WaterSourceQualityGoodByWQI = null,
                TimePeriodWaterBalance = CP3,
                DensityOfWaterQualityMonitoringSystem = CD3/AX3,
                IndustrialDensity = P3/AX3,
                IndustrialHasWastewaterPerAllIndustrial = AB3/P3*100,
                CostOfFloodPerAllArea = null,
                RepeatedFloodAreasPerArea = BD3/AX3*100,
                AreHasChanceOfLandslidesPerArea = BC3/AX3*100,
                PopulationInFloodAreaPerPopulation = AC3/N3*100,
                TransportationFloodedAreas = BK3/BD3,
                AreaOfFloodPerAreaIncity = CO3/AY3*100,
                PeriodOfFlooding = U3,
                DepthOfFlood = T3,
                VillagesWarningPerVillages = Z3/AR3*100,
                CostDroughtPerYearPerArea = null,
                RepeatedDroughtAreasPerEntire = BE3/AX3*100,
                AgriculturalAreaInRepeatedDrought = CN3/BG3*100,
                ForestAreaPerArea = BL3/AX3*100,
                NDVI = BM3,
                ConserveAndManage = IF(CH3>0,AX3/CH3,IF(CH3=0,0)),
                PlanWaterManagement = null,
                ParticipatingIrrigationProjects = null,
                DistributionOfParticipatingIrrigationProjects = null,
                GPPPerWaterCost = null,
                GPPPerPopulation = null,
                WorkingAgePerPopulation = O3/N3*100,
                ResearchOnWaterResourcesManagement = null,
                WaterwaysAreSuitableForWaterTransportation = null,
                CoverageMonitoringSystem = AX3/CD3,
                GoodCoverageMonitoringSystem = CE3/CD3*100,
                ReservoirHasGoodManagement = null
            };

            //TODO: insert it to DB
        }
    }
}