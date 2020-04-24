using MongoDB.Bson.Serialization.Attributes;

namespace ProIndex.Models
{
    public class AllIndex
    {
        [BsonId]
        public string _id { get; set; }

        /// <summary>
        /// รหัสภาค
        /// </summary>
        /// <value></value>
        public string REG { get; set; }

        /// <summary>
        /// ภาค
        /// </summary>
        /// <value></value>
        public string REG_NAME { get; set; }

        /// <summary>
        /// รหัสจังหวัด
        /// </summary>
        /// <value></value>
        public string CWT { get; set; }

        /// <summary>
        /// จังหวัด
        /// </summary>
        /// <value></value>
        public string CWT_NAME { get; set; }

        /// <summary>
        /// รหัวอำเภอ
        /// </summary>
        /// <value></value>
        public string AMP { get; set; }

        /// <summary>
        /// อำเภอ
        /// </summary>
        /// <value></value>
        public string AMP_NAME { get; set; }

        /// <summary>
        /// รหัสตำบล
        /// </summary>
        /// <value></value>
        public string TAM { get; set; }

        /// <summary>
        /// ตำบล
        /// </summary>
        /// <value></value>
        public string TAM_NAME { get; set; }
        /// <summary>
        /// (1.1) ปริมาณน้ำฝนเฉลี่ยรายปี
        /// </summary>
        /// <value></value>
        public double? RainEveryYear { get; set; }

        /// <summary>
        /// (1.2) ปริมาณน้ำท่าเฉลี่ยรายปีต่อประชากร
        /// </summary>
        /// <value></value>
        public double? RainEveryYearPerPopulation { get; set; }

        /// <summary>
        /// (1.3) ปริมาณการเติมน้ำบาดาลรายปีต่อประชากร
        /// </summary>
        /// <value></value>
        public double? GroundWaterEveryYearPerPopulation { get; set; }

        /// <summary>
        /// (1.4) ปริมาณน้ำเก็บกักรายปีต่อประชากร
        /// </summary>
        /// <value></value>
        public double? WaterStoreEveryYearPerPopulation { get; set; }

        /// <summary>
        /// (1.5) ปริมาณน้ำเก็บกักต่อน้ำท่า
        /// </summary>
        /// <value></value>
        public double? WaterStorePerWaterfront { get; set; }

        /// <summary>
        /// (1.6) ปริมาณน้ำบาดาลที่พัฒนามาใช้ต่อประชากร
        /// </summary>
        /// <value></value>
        public double? GroundWaterImprovePerPopulation { get; set; }

        /// <summary>
        /// (1.7) คุณภาพน้ำผิวดิน
        /// </summary>
        /// <value></value>
        public double? QualitySurfaceWater { get; set; }

        /// <summary>
        /// (1.8) คุณภาพน้ำบาดาล
        /// </summary>
        /// <value></value>
        public double? QualityGroundWater { get; set; }

        /// <summary>
        /// (2.1) ครัวเรือนในชนบทที่มีน้ำประปาใช้ต่อคร้วเรือนในชนบททั้งหมด
        /// </summary>
        /// <value></value>
        public double? HouseHoldHavePlumpingPerAllHouseHold { get; set; }

        /// <summary>
        /// (2.2) ครัวเรือนในเขตเมืองที่มีน้ำประปาใช้ต่อคร้วเรือนในเขตเมืองทั้งหมด
        /// </summary>
        /// <value></value>
        public double? HouseHoldInCityHavePlumpingPerAllHouseHold { get; set; }

        /// <summary>
        ///  (2.3) สถานที่ราชการที่มีน้ำประปาใช้ต่อสถานที่ราชการทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? GovernmentHasPumping { get; set; }

        /// <summary>
        /// (2.4) ครัวเรือนที่มีน้ำประปาคุณภาพดีต่อคร้วเรือนทั้งหมด(ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? HouseholdHasGoodPumping { get; set; }

        /// <summary>
        /// (2.5) ปริมาณการใช้น้ำอุปโภค บริโภคต่อคน (ลิตร/คน/วัน)
        /// </summary>
        /// <value></value>
        public double? ConsumptionOfWater { get; set; }

        /// <summary>
        /// (2.6) สถานที่ราชการที่มีน้ำประปาคุณภาพดีต่อสถานที่ราชการที่มีน้ำประปาทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? GovernmentHasGoodPumping { get; set; }

        /// <summary>
        /// (2.7) เวลาที่มีน้ำประปาใช้ในรอบปี (เดือน)
        /// </summary>
        /// <value></value>
        public double? TimeHasPumpingPerYear { get; set; }

        /// <summary>
        /// (3.1.1) พื้นที่ชลประทานต่อพื้นที่เกษตรกรรม (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? AreaOfIrrigationPerAreaOfAgriculture { get; set; }

        /// <summary>
        /// (3.1.2) ครัวเรือนที่มีพื้นที่เกษตรกรรมในเขตชลประทาน (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? HouseholdHasAgricultureInIrrigation { get; set; }

        /// <summary>
        /// (3.1.3) ความจุของอ่างเก็บน้ำต่อพื้นที่เกษตรกรรม (ลบ.ม./ไร่)
        /// </summary>
        /// <value></value>
        public double? ReservoirPerAreaOfAgriculture { get; set; }

        /// <summary>
        /// (3.1.4) ผลิตภาพการใช้น้ำด้านเกษตรกรรม (บาท/ลบ.ม.)
        /// </summary>
        /// <value></value>
        public double? WaterUsageForAgriculture { get; set; }

        /// <summary>
        /// (3.1.5) คุณภาพน้ำที่ใช้ในการเกษตร (น้ำชลประทาน น้ำผิวดิน น้ำบาดาล)
        /// </summary>
        /// <value></value>
        public double? WaterQualityForAgriculture { get; set; }

        /// <summary>
        /// (3.2.1) ผลิตภาพการใช้น้ำด้านอุตสาหกรรม (บาท/ลบ.ม.)
        /// </summary>
        /// <value></value>
        public double? WaterUsageForFactory { get; set; }

        /// <summary>
        /// (3.2.2) คุณภาพน้ำที่ใช้ในการผลิต (น้ำประปา น้ำผิวดิน น้ำบาดาล) (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WaterQualityForFactory { get; set; }

        /// <summary>
        /// (3.3.1) ผลิตภาพการใช้น้ำด้านบริการ  (บาท/ลบ.ม.)
        /// </summary>
        /// <value></value>
        public double? WaterUsageForSurvice { get; set; }

        /// <summary>
        /// (3.3.2) คุณภาพน้ำที่ใช้ในการบริการ (น้ำประปา น้ำผิวดิน น้ำบาดาล) (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WaterQualitySurvice { get; set; }

        /// <summary>
        /// (4.1) สมดุลของน้ำต้นทุนและการใช้น้ำ (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WaterBalanceCostAndWaterUse { get; set; }

        /// <summary>
        /// (5.1) โรงงานอุตสาหกรรมที่มีระบบบำบัดน้ำเสียต่อโรงงานอุตสาหกรรมทั้งหมด  (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? FactoryHasTreatmentSystem { get; set; }

        /// <summary>
        /// (5.2) พื้นที่เมือง ชุมชนที่อยู่อาศัยต่อพื้นที่ทั้งหมด  (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? AreaOfHouseholdPerAllAreaInCity { get; set; }

        /// <summary>
        /// (5.3) หมู่บ้านที่มีระบบบำบัดน้ำเสียต่อหมู่บ้านทั้งหมด  (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? CommunityHasTreatmentSystemPerAllCommunity { get; set; }

        /// <summary>
        /// (5.4) แหล่งน้ำที่มีคุณภาพน้ำระดับพอใช้ขึ้นไป ตาม WQI  (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WaterSourceQualityGoodByWQI { get; set; }

        /// <summary>
        /// (5.5) ช่วงเวลาที่มีปริมาณน้ำรักษาสมดุลนิเวศท้ายน้ำตามมาตรฐาน (เดือน)
        /// </summary>
        /// <value></value>
        public double? TimePeriodWaterBalance { get; set; }

        /// <summary>
        /// (5.6) ความหนาแน่นของระบบติดตามคุณภาพน้ำ(ผิวดินและบาดาล) (สถานี/ตร.กม.)
        /// </summary>
        /// <value></value>
        public double? DensityOfWaterQualityMonitoringSystem { get; set; }

        /// <summary>
        /// (5.7) ความหนาแน่นของโรงงานอุตสาหกรรม (โรงงาน/ตร.กม.)
        /// </summary>
        /// <value></value>
        public double? IndustrialDensity { get; set; }

        /// <summary>
        /// (5.8) โรงงานอุตสาหกรรมที่มีน้ำเสียจากระบบการผลิตต่อโรงงานอุตสาหกรรมทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? IndustrialHasWastewaterPerAllIndustrial { get; set; }

        /// <summary>
        /// (6.1.1) มูลค่าความเสียหายจากน้ำท่วมต่อปี/พื้นที่น้ำทั้งหมด (บาท/ตร.กม.)
        /// </summary>
        /// <value></value>
        public double? CostOfFloodPerAllArea { get; set; }

        /// <summary>
        /// (6.1.2) พื้นที่น้ำท่วมซ้ำซากต่อพื้นที่ทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? RepeatedFloodAreasPerArea { get; set; }

        /// <summary>
        /// (6.1.3) พื้นที่มีโอกาสเกิดดินถล่มต่อพื้นที่ทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? AreHasChanceOfLandslidesPerArea { get; set; }

        /// <summary>
        /// (6.1.4) ประชากรในพื้นที่น้ำท่วมต่อประชากรทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? PopulationInFloodAreaPerPopulation { get; set; }

        /// <summary>
        /// (6.1.5) ความหนาแน่นของเส้นทางคมนาคมในพื้นที่น้ำท่วมซ้ำซาก (กม./ตร.กม.)
        /// </summary>
        /// <value></value>
        public double? TransportationFloodedAreas { get; set; }

        /// <summary>
        /// (6.1.6) พื้นที่เขตเมืองในเขตพื้นที่น้ำท่วมซ้ำซากต่อพื้นที่เขตเมืองทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? AreaOfFloodPerAreaIncity { get; set; }

        /// <summary>
        /// (6.1.7) ระยะเวลาที่น้ำท่วมขัง (ในเขตที่อยู่อาศัย) (ชั่วโมง)
        /// </summary>
        /// <value></value>
        public double? PeriodOfFlooding { get; set; }

        /// <summary>
        /// (6.1.8) ระดับความลึกของน้ำท่วม (ในเขตที่อยู่อาศัย) (เมตร)
        /// </summary>
        /// <value></value>
        public double? DepthOfFlood { get; set; }

        /// <summary>
        /// (6.1.9) หมู่บ้านในพื้นที่น้ำท่วมที่มีการเตือนภัยและมาตรการช่วยเหลือต่อหมู่บ้านทั้งหมดในพื้นที่น้ำท่วม (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? VillagesWarningPerVillages { get; set; }

        /// <summary>
        /// (6.2.1) มูลค่าความเสียหายจากภัยแล้งต่อปี/พื้นที่ทั้งหมด (บาท/ตร.กม.)
        /// </summary>
        /// <value></value>
        public double? CostDroughtPerYearPerArea { get; set; }

        /// <summary>
        /// (6.2.2) พื้นที่แล้งซ้ำซากต่อพื้นที่ทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? RepeatedDroughtAreasPerEntire { get; set; }

        /// <summary>
        /// (6.2.3) พื้นที่เกษตรกรรมในพื้นที่แล้งซ้ำซากต่อพื้นที่เกษตรกรรมทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? AgriculturalAreaInRepeatedDrought { get; set; }

        /// <summary>
        /// (7.1) พื้นที่ป่าไม้ต่อพื้นที่ทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? ForestAreaPerArea { get; set; }

        /// <summary>
        /// (7.2) ความสมบูรณ์ของป่าไม้ (NDVI)
        /// </summary>
        /// <value></value>
        public double? NDVI { get; set; }

        /// <summary>
        /// (7.3) การกระจายขององค์กรด้านการอนุรักษ์และจัดการป่า (ตร.กม./องค์กร)
        /// </summary>
        /// <value></value>
        public double? ConserveAndManage { get; set; }

        /// <summary>
        /// (8.1.1) แผนการจัดการน้ำ (แผน)
        /// </summary>
        /// <value></value>
        public double? PlanWaterManagement { get; set; }

        /// <summary>
        /// (8.2.1) โครงการชลประทานที่มีส่วนร่วมต่อโครงการชลประทานทั้งหมดในพื้นที่ (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? ParticipatingIrrigationProjects { get; set; }

        /// <summary>
        /// (8.3.1) การกระจายขององค์กรจัดการน้ำ (ตร.กม./องค์กร)
        /// </summary>
        /// <value></value>
        public double? DistributionOfParticipatingIrrigationProjects { get; set; }

        /// <summary>
        /// (8.4.1) GPPต่อปริมาณน้ำต้นทุน (บาท/ลบ.ม.)
        /// </summary>
        /// <value></value>
        public double? GPPPerWaterCost { get; set; }

        /// <summary>
        /// (8.4.2) GPPต่อประชากร (บาท/คน)
        /// </summary>
        /// <value></value>
        public double? GPPPerPopulation { get; set; }

        /// <summary>
        /// (8.4.3) จำนวนประชากรวัยทำงานต่อประชากรทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WorkingAgePerPopulation { get; set; }

        /// <summary>
        /// (8.4.4) การวิจัยด้านการจัดการทรัพยากรน้ำ (โครงการ)
        /// </summary>
        /// <value></value>
        public double? ResearchOnWaterResourcesManagement { get; set; }

        /// <summary>
        /// (8.5.1) ทางน้ำที่มีสภาพเหมาะสมในการขนส่งทางน้ำต่อทางน้ำทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public double? WaterwaysAreSuitableForWaterTransportation { get; set; }

        /// <summary>
        /// (8.6.1) ความครอบคุมของระบบติดตามตรวจสอบ (ตร.กม./สถานี)
        /// </summary>
        /// <value></value>
        public double? CoverageMonitoringSystem { get; set; }

        /// <summary>
        /// (8.6.2) ระบบติดตามตรวจสอบที่มีประสิทธิภาพและมีการบำรุงรักษาต่อระบบทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public int GoodCoverageMonitoringSystem { get; set; }

        /// <summary>
        /// (8.7.1) อ่างเก็บน้ำที่มีการจัดสรรอย่างเป็นระบบต่ออ่างเก็บน้ำทั้งหมด (ร้อยละ)
        /// </summary>
        /// <value></value>
        public int? ReservoirHasGoodManagement { get; set; }
    }
}