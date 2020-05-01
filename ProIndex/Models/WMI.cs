namespace ProIndex.Models
{
    public class WMI
    {
        /// <summary>
        /// (1)ต้นทุนทรัพยากรน้ำ
        /// </summary>
        /// <value></value>
        public double? HasWater { get; set; }

        /// <summary>
        /// (2)การจัดการน้ำเพื่อการอุปโภค บริโภค
        /// </summary>
        /// <value></value>
        public double? WaterManagementForUse { get; set; }

        /// <summary>
        /// (3.1)ด้านเกษตรกรรม
        /// </summary>
        /// <value></value>
        public double? Agriculture { get; set; }

        /// <summary>
        /// (3.2)ด้านอุตสาหกรรม
        /// </summary>
        /// <value></value>
        public double? Factory { get; set; }

        /// <summary>
        /// (3.3) ด้านบริการ
        /// </summary>
        /// <value></value>
        public double? Service { get; set; }

        /// <summary>
        /// (3)ความมั่นคงของน้ำเพื่อการพัฒนา
        /// </summary>
        /// <value></value>
        public double? WaterForDevelopment { get; set; }

        /// <summary>
        ///  (4)ความสมดุลของน้ำต้นทุนและการใช้น้ำ
        /// </summary>
        /// <value></value>
        public double? WaterBalanceCostAndUse { get; set; }

        /// <summary>
        /// (5)การจัดการคุณภาพน้ำและสิ่งแวดล้อม
        /// </summary>
        /// <value></value>
        public double? WaterQualityAndEnvironmentalManagement { get; set; }

        /// <summary>
        /// (6.1)ด้านน้ำท่วม
        /// </summary>
        /// <value></value>
        public double? Flood { get; set; }

        /// <summary>
        /// (6.2)ด้านภัยแล้ง
        /// </summary>
        /// <value></value>
        public double? Drought { get; set; }

        /// <summary>
        /// (6)การจัดการภัยพิบัติที่เกิดจากน้ำ
        /// </summary>
        /// <value></value>
        public double? WaterDisasterManagement { get; set; }

        /// <summary>
        /// (7)การจัดการและอนุรักษ์ป่าต้นน้ำ
        /// </summary>
        /// <value></value>
        public double? WatershedForestManagement { get; set; }

        /// <summary>
        /// (8.1)ด้านแผนการจัดการลุ่มน้ำ
        /// </summary>
        /// <value></value>
        public double? BasinManagementPlans { get; set; }

        /// <summary>
        /// (8.2)ด้านการมีส่วนร่วมในการจัดการน้ำ
        /// </summary>
        /// <value></value>
        public double? ParticipationWaterManagement { get; set; }

        /// <summary>
        /// (8.3)ด้านองค์กรจัดการน้ำ
        /// </summary>
        /// <value></value>
        public double? WaterManagementOrganization { get; set; }

        /// <summary>
        /// (8.4) ด้านศักยภาพในการพัฒนา
        /// </summary>
        /// <value></value>
        public double? DevelopmentPotential { get; set; }

        /// <summary>
        /// (8.5)ด้านการรักษาสภาพทางน้ำเพื่อการขนส่งทางน้ำ
        /// </summary>
        /// <value></value>
        public double? MaintainingForWaterTransportation { get; set; }

        /// <summary>
        ///  (8.6)ด้านการติดตามตรวจสอบ
        /// </summary>
        /// <value></value>
        public double? Tracking { get; set; }

        /// <summary>
        /// (8.7)ด้านการจัดสรรน้ำ
        /// </summary>
        /// <value></value>
        public double? WaterAllocation { get; set; }

        /// <summary>
        /// (8)การบริหารจัดการทรัพยากรน้ำ
        /// </summary>
        /// <value></value>
        public double? WaterResourcesManagement { get; set; }
    }
}