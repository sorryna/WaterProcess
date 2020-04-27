using MongoDB.Bson.Serialization.Attributes;

namespace ProIndex.Models
{
    public class SurveyAndCompany
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
        /// 1.ครัวเรือนเกษตรกรรม
        /// </summary>
        /// <value></value>
        public int IsAgriculture { get; set; }

        /// <summary>
        /// 2.ครัวเรือนทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsHouseHold { get; set; }

        /// <summary>
        /// 3.ครัวเรือนที่มีน้ำประปาคุณภาพดี  
        /// </summary>
        /// <value></value>
        public double IsHouseHoldGoodPlumbing { get; set; }

        /// <summary>
        /// 4.ครัวเรือนที่มีพื้นที่เกษตรกรรมในพื้นที่ชลประทาน
        /// </summary>
        /// <value></value>
        public double IsAgricultureHasIrrigationField { get; set; }

        /// <summary>
        /// 5.ครัวเรือนในเขตเมืองที่มีน้ำประปาใช้ (ในเขตเทศบาล)
        /// </summary>
        /// <value></value>
        public double IsHouseHoldHasPlumbingDistrict { get; set; }

        /// <summary>
        /// 6.ครัวเรือนในชนบทที่มีน้ำประปาใช้ (นอกเขตเทศบาล)
        /// </summary>
        /// <value></value>
        public double IsHouseHoldHasPlumbingCountryside { get; set; }

        /// <summary>
        /// 7.คุณภาพน้ำที่ใช้ในการผลิต (น้ำประปา ผิวดิน น้ำบาดาล)
        /// </summary>
        /// <value></value>
        public double IsFactorialWaterQuality { get; set; }

        /// <summary>
        /// 8.คุณภาพน้ำที่ใช้ในภาคบริการ (น้ำประปา ผิวดิน น้ำบาดาล)
        /// </summary>
        /// <value></value>
        public double IsCommercialWaterQuality { get; set; }

        /// <summary>
        /// สน.1 9.จำนวนบ่อน้ำบาดาล
        /// </summary>
        /// <value></value>
        public double CountGroundWaterUnit { get; set; }

        /// <summary>
        /// สน.2 9.จำนวนบ่อน้ำบาดาล
        /// </summary>
        /// <value></value>
        public double CountGroundWaterCom { get; set; }

        /// <summary>
        /// 10.จำนวนประชากร
        /// </summary>
        /// <value></value>
        public double CountPopulation { get; set; }

        /// <summary>
        /// 11.จำนวนประชากรวัยทำงาน
        /// </summary>
        /// <value></value>
        public double CountWorkingAge { get; set; }

        /// <summary>
        /// 12.โรงงานอุตสาหกรรมทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsFactorial { get; set; }

        /// <summary>
        /// 13.โรงงานอุตสาหกรรมที่มีระบบบำบัดน้ำเสีย
        /// </summary>
        /// <value></value>
        public double IsFactorialWaterTreatment { get; set; }

        /// <summary>
        /// 14.หมู่บ้านที่มีระบบบำบัดน้ำเสีย
        /// </summary>
        /// <value></value>
        public double IsCommunityWaterManagementHasWaterTreatment { get; set; }

        /// <summary>
        /// 15.พื้นที่ชลประทาน
        /// </summary>
        /// <value></value>
        public double FieldCommunity { get; set; }

        /// <summary>
        /// 16.ระดับความลึกของน้ำท่วม (ในเขตที่อยู่อาศัย)
        /// </summary>
        /// <value></value>
        public double AvgWaterHeightCm { get; set; }

        /// <summary>
        /// 17.ระยะเวลาที่น้ำท่วมขัง (ในเขตที่อยู่อาศัย)
        /// </summary>
        /// <value></value>
        public double TimeWaterHeightCm { get; set; }

        /// <summary>
        /// 18.ระยะเวลาที่มีน้ำประปาใช้ (เดือน) 
        /// </summary>
        /// <value></value>
        public double HasntPlumbing { get; set; }

        /// <summary>
        /// 19.สถานที่ราชการทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsGovernment { get; set; }

        /// <summary>
        /// 20.สถานที่ราชการที่มีน้ำประปาใช้
        /// </summary>
        /// <value></value>
        public double IsGovernmentUsage { get; set; }

        /// <summary>
        /// 21.สถานที่ราชการที่มีน้ำประปาที่มีคุณภาพมาตรฐาน
        /// </summary>
        /// <value></value>
        public double IsGovernmentWaterQuality { get; set; }

        /// <summary>
        /// 22.หมู่บ้านในพื้นที่น้ำท่วมซ้ำซากที่มีการเตือนภัยและมาตรการช่วยเหลือ
        /// </summary>
        /// <value></value>
        public double CommunityNatureDisaster { get; set; }

        /// <summary>
        /// สน.1  23.แหล่งน้ำขนาดใหญ่ กลาง และเล็ก
        /// </summary>
        /// <value></value>
        public double WaterSourcesUnit { get; set; }

        /// <summary>
        /// สน.2 23.แหล่งน้ำขนาดใหญ่ กลาง และเล็ก
        /// </summary>
        /// <value></value>
        public double WaterSourcesCom { get; set; }

        /// <summary>
        /// 24.จำนวนโรงงานอุตสาหกรรมที่มีน้ำเสียจากระบบ
        /// </summary>
        /// <value></value>
        public double IndustryHasWasteWaterTreatment { get; set; }

        /// <summary>
        /// 25.ประชากรที่อาศัยในครัวเรือนที่มีน้ำท่วม 
        /// </summary>
        /// <value></value>
        public double PeopleInFloodedArea { get; set; }

        /// <summary>
        /// 26.ปริมาณการใช้น้ำบาดาลเพื่อการเกษตร(น้ำบาดาล น้ำซื้อ) สน.2
        /// </summary>
        public double CubicMeterGroundWaterForAgriculture { get; set; }

        /// <summary>
        /// 27. ปริมาณการใช้น้ำบาดาลเพื่อการบริการ(น้ำบาดาล น้ำซื้อ)
        /// </summary>
        public double CubicMeterGroundWaterForService { get; set; }

        /// <summary>
        /// 28. ปริมาณการใช้น้ำบาดาลเพื่อการอุตสาหกรรม(น้ำบาดาล น้ำซื้อ)
        /// </summary>
        public double CubicMeterGroundWaterForProduct { get; set; }

        /// <summary>
        /// 29.ปริมาณการใช้น้ำบาดาลเพื่อการอุปโภคบริโภค(น้ำบาดาล น้ำซื้อ) สน.2
        /// </summary>
        public double CubicMeterGroundWaterForDrink { get; set; }

        /// <summary>
        /// 30. ปริมาณการใช้น้ำประปาเพื่อการเกษตร
        /// </summary>
        public double CubicMeterPlumbingForAgriculture { get; set; }

        /// <summary>
        /// 31. ปริมาณการใช้น้ำประปาเพื่อการบริการ
        /// </summary>
        public double CubicMeterPlumbingForService { get; set; }

        /// <summary>
        /// 32. ปริมาณการใช้น้ำประปาเพื่อการอุตสาหกรรม
        /// </summary>
        public double CubicMeterPlumbingForProduct { get; set; }

        /// <summary>
        /// 33. ปริมาณการใช้น้ำประปาเพื่อการอุปโภคบริโภค 
        /// </summary>
        public double CubicMeterPlumbingForDrink { get; set; }

        /// <summary>
        /// 34. ปริมาณการใช้น้ำผิวดินเพื่อการเกษตร (สระน้ำ แม่น้ำ ชลประทาน น้ำฝนกักเก็บ) สน.1
        /// </summary>
        public double CubicMeterSurfaceForAgriculture { get; set; }

        /// <summary>
        /// 35. ปริมาณการใช้น้ำผิวดินเพื่อการบริการ (สระน้ำ แม่น้ำ ชลประทาน น้ำฝนกักเก็บ)
        /// </summary>
        public double CubicMeterSurfaceForService { get; set; }

        /// <summary>
        /// 36. ปริมาณการใช้น้ำผิวดินเพื่อการอุตสาหกรรม (สระน้ำ แม่น้ำ ชลประทาน น้ำฝนกักเก็บ)
        /// </summary>
        public double CubicMeterSurfaceForProduct { get; set; }

        /// <summary>
        /// 37. ปริมาณการใช้น้ำผิวดินเพื่อการอุปโภคบริโภค (สระน้ำ แม่น้ำ ชลประทาน น้ำฝนกักเก็บ) สน.1
        /// </summary>
        public double CubicMeterSurfaceForDrink { get; set; }

        /// <summary>
        /// 38.ปริมาณน้ำบาดาลที่พัฒนามาใช้ สน.2 (ปริมาณน้ำจากรายการ 26,29)
        /// </summary>
        public double CubicMeterGroundWaterForUse { get; set; }

        /// <summary>
        /// 39.จำนวนหมู่บ้าน/ชุมชนทั้งหมด
        /// </summary>
        /// <value></value>
        public double CountCommunity { get; set; }

        /// <summary>
        /// 40.จำนวนหมู่บ้าน/ชุมชนที่มีอุทกภัย ดินโคลนถล่ม
        /// </summary>
        /// <value></value>
        public double CountCommunityHasDisaster { get; set; }

        /// <summary>
        /// 41.ครัวเรือนในชนบททั้งหมด
        /// </summary>
        /// <value></value>
        public double IsAllHouseHoldCountryside { get; set; }

        /// <summary>
        /// 42.ครัวเรือนในเขตเมืองทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsAllHouseHoldDistrict { get; set; }

        /// <summary>
        /// 43.สถานประกอบการผลิตทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsAllFactorial { get; set; }

        /// <summary>
        /// 44.สถานประกอบการบริการทั้งหมด
        /// </summary>
        /// <value></value>
        public double IsAllCommercial { get; set; }

        /// <summary>
        /// (45) ขอบเขตพื้นที่ลุ่มน้ำและลุ่มน้ำย่อย _(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfSubBasin { get; set; }

        /// <summary>
        /// (46) ขอบเขตพื้นที่ตำบล_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfSubdistrict { get; set; }

        /// <summary>
        /// (47)ขอบเขตพื้นที่เขตเมือง_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfCity { get; set; }

        /// <summary>
        /// (48)ขอบเขตพื้นที่อำเภอ_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfDistrict  { get; set; }

        /// <summary>
        /// (49)ขอบเขตพื้นที่จังหวัด_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfProvince { get; set; }

        /// <summary>
        /// (50)ขอบเขตพื้นที่ภูมิภาค_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfReg { get; set; }

        /// <summary>
        /// (51)แผนที่พื้นที่ที่มีโอกาสเกิดดินถล่ม_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaHasChanceLandSlide { get; set; }

        /// <summary>
        /// (52)แผนที่พื้นที่น้ำท่วมซ้ำซาก_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaHasChanceFlood { get; set; }

        /// <summary>
        /// (53)แผนที่พื้นที่เสี่ยงภัยแล้งซ้ำซาก_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaHasChanceDrought { get; set; }

        /// <summary>
        /// (54)แผนที่การใช้ประโยชน์ที่ดิน
        /// </summary>
        /// <value></value>
        public double LandUse { get; set; }

        /// <summary>
        /// (55)พื้นที่เกษตรกรรมทั้งหมด_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfAgriculture { get; set; }

        /// <summary>
        /// (56)พื้นที่เกษตรกรรมในเขตชลประทาน_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfAgricultureHasIrrigation { get; set; }

        /// <summary>
        /// (57)มูลค่าความเสียหาย ต่อปีจากน้ำแล้ง_(บาท)
        /// </summary>
        /// <value></value>
        public double DamageCostOfDroughtPerYear  { get; set; }

        /// <summary>
        /// (58)มูลค่าความเสียหาย ต่อปีจากน้ำท่วม_(บาท)
        /// </summary>
        /// <value></value>
        public double DamageCostOfFloodPerYear  { get; set; }

        /// <summary>
        /// (59)ความยาวเส้นทางคมนาคมในพื้นที่น้ำท่วมซ้ำซาก_(กม.)
        /// </summary>
        /// <value></value>
        public double LengthOfRoadInAreaOfFlood { get; set; }

        /// <summary>
        /// (60)แผนที่พื้นที่ป่าไม้_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfForest { get; set; }

        /// <summary>
        /// (61)ค่าดัชนีพืชพรรณ_(ค่าคะแนนNDVI)
        /// </summary>
        /// <value></value>
        public double IndexOfPlant { get; set; }

        /// <summary>
        /// (62)ความยาวของทางน้ำสายหลักทั้งหมด_(กม.)
        /// </summary>
        /// <value></value>
        public double LengthOfMainRiver { get; set; }

        /// <summary>
        /// (63)ความยาวของทางน้ำสายหลักที่มีสภาพเหมาะสมในการขนส่งทางน้ำ_(กม.)
        /// </summary>
        /// <value></value>
        public double LengthOfMainRiverAppropriateToWaterTransport { get; set; }

        /// <summary>
        /// (64)ค่า TDS ของน้ำบาดาล_(ค่าคะแนน)
        /// </summary>
        /// <value></value>
        public double TDSOfGroundWater { get; set; }

        /// <summary>
        /// (65)ปริมาณการเติมน้ำบาดาลรายปี_(ล้าน ลบ.ม./ปี)
        /// </summary>
        /// <value></value>
        public double RefillGroundWaterPerYear { get; set; }

        /// <summary>
        /// (66)ปริมาณน้ำท่าเฉลี่ยรายปี_(ล้าน ลบ.ม./ปี)
        /// </summary>
        /// <value></value>
        public double SurfaceWaterPerYear { get; set; }

        /// <summary>
        /// (67)ปริมาณน้ำท่ารายเดือน_(ล้าน ลบ.ม./เดือน)
        /// </summary>
        /// <value></value>
        public double SurfaceWaterPerMonth { get; set; }

        /// <summary>
        /// (68)ปริมาณน้ำฝนรายปี_(มม./ปี)
        /// </summary>
        /// <value></value>
        public double RainPerYear { get; set; }

        /// <summary>
        /// (69)ปริมาณน้ำฝนรายวัน
        /// </summary>
        /// <value></value>
        public double RainPerDay { get; set; }

        /// <summary>
        /// (70)ปริมาณน้ำรักษาระบบนิเวศ_(ล้าน ลบ.ม./เดือน)
        /// </summary>
        /// <value></value>
        public double WaterOfPreservingEcosystem { get; set; }

        /// <summary>
        /// (71)อ่างเก็บน้ำทั้งหมด_(แห่ง)
        /// </summary>
        /// <value></value>
        public int Reservoir { get; set; }

        /// <summary>
        /// (72)ปริมาตรความจุใช้งานของอ่างเก็บน้ำ_(ล้าน ลบ.ม.)
        /// </summary>
        /// <value></value>
        public double CapacityOfReservoir { get; set; }

        /// <summary>
        /// (73)อ่างเก็บน้ำที่มีการจัดสรรน้ำอย่างเป็นระบบ_(แห่ง)
        /// </summary>
        /// <value></value>
        public int ReservoirHasAllocate { get; set; }

        /// <summary>
        /// (74)แหล่งน้ำที่มีคะแนนตาม WQI เฉลี่ยรายปี_(ค่าคะแนน)
        /// </summary>
        /// <value></value>
        public double WatersourceAvgWQIPerYear { get; set; }

        /// <summary>
        /// (75)ประเภทแหล่งน้ำผิวดิน_(ตามเกณฑ์ WQI)
        /// </summary>
        /// <value></value>
        public string TypeOfSurFaceWaterByWQI { get; set; }

        /// <summary>
        /// (76)จำนวนโครงการชลประทานทั้งหมด_(โครงการ)
        /// </summary>
        /// <value></value>
        public int IrrigationProject { get; set; }

        /// <summary>
        /// (77)จำนวนโครงการชลประทานที่มีการมีส่วนร่วม_(โครงการ)
        /// </summary>
        /// <value></value>
        public int IrrigationProjectHasParticipate { get; set; }

        /// <summary>
        /// (78)จำนวนสถานีติดตามปริมาณและคุณภาพน้ำทั้งหมด_(สถานี)
        /// </summary>
        /// <value></value>
        public int WaterTrackingStation { get; set; }

        /// <summary>
        /// (79)จำนวนสถานีติดตามปริมาณและคุณภาพน้ำที่มีประสิทธิภาพและมีการบำรุงรักษา_(สถานี)
        /// </summary>
        /// <value></value>
        public int GoodWaterTrackingStation { get; set; }

        /// <summary>
        /// (80)จำนวนโครงการวิจัยด้านการจัดการทรัพยากรน้ำ_(โครงการ)
        /// </summary>
        /// <value></value>
        public int WaterResourcesManagementProject { get; set; }

        /// <summary>
        /// (81)จำนวนองค์กรจัดการน้ำในพื้นที่_(องค์กร)
        /// </summary>
        /// <value></value>
        public int WaterManagementCompany { get; set; }

        /// <summary>
        /// (82)จำนวนองค์กรบริหารจัดการป่าชุมชน_(องค์กร)
        /// </summary>
        /// <value></value>
        public int ForestManagementCompany { get; set; }

        /// <summary>
        /// (83)แผนการจัดการน้ำในพื้นที่_(แผน)
        /// </summary>
        /// <value></value>
        public int PlanOfWaterManagrmentInArea { get; set; }

        /// <summary>
        /// (84)ผลิตภัณฑ์มวลรวมจังหวัด (GPP)_(ล้านบาท)
        /// </summary>
        /// <value></value>
        public int GPPOfProvince { get; set; }

        /// <summary>
        /// (85)ผลิตภัณฑ์มวลรวมจังหวัดด้านการเกษตร_(ล้านบาท)
        /// </summary>
        /// <value></value>
        public int GPPOfAgricultureInProvince { get; set; }

        /// <summary>
        /// (86)ผลิตภัณฑ์มวลรวมจังหวัดด้านการอุตสาหกรรม_(ล้านบาท)
        /// </summary>
        /// <value></value>
        public int GPPOfCommercialInProvince { get; set; }

        /// <summary>
        /// (87)ผลิตภัณฑ์มวลรวมจังหวัดด้านการบริการ_(ล้านบาท)
        /// </summary>
        /// <value></value>
        public int GPPOfServiceInProvince { get; set; }

        /// <summary>
        /// (88)พื้นที่เกษตรกรรมในพื้นที่แล้งซ้ำซาก_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public double AreaOfAgricultureInDrought { get; set; }

        /// <summary>
        /// (89)พื้นที่เขตเมืองในเขตพื้นที่น้ำท่วมซ้ำซาก_(ตร.กม.)
        /// </summary>
        /// <value></value>
        public int AreaOfCityHasFlood { get; set; }

        /// <summary>
        /// (90)จำนวนเดือนที่มีน้ำรักษาระบบนิเวศท้ายน้ำ_(เดือน)
        /// </summary>
        /// <value></value>
        public int MonthPreservingEcosystems { get; set; }

        /// <summary>
        /// (91)จำนวนจุดตรวจวัดค่า WQI ที่มีค่ามากกว่า 61_(จุด)
        /// </summary>
        /// <value></value>
        public int HasMeasurementWQIOverSixOne { get; set; }

        /// <summary>
        /// (92)จำนวนจุดตรวจวัดค่า WQI ทั้งหมด_(จุด)
        /// </summary>
        /// <value></value>
        public int MeasurementWQI { get; set; }
    }
}