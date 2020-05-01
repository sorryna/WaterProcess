using System;

namespace ProIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // CalIndex();
            CalRivaer();
        }

        public static void CalIndex()
        {
            var connectDB = new GetData();
            var getDataFromDB = connectDB.Get92Data();
            foreach (var item in getDataFromDB)
            {
                var count = 0;
                count++;
                var indexData = new ProcressIndex();
                var resultIndex = indexData.Propcress(item);
                connectDB.InsertIndexToDB(resultIndex);

                var pointData = new ProceassPoint();
                var resultPoint = pointData.Procress(resultIndex);
                connectDB.InsertPointToDB(resultPoint);
                System.Console.WriteLine(count);
            }
        }

        public static void CalRivaer()
        {
            var connectDB = new GetData();
            var getDataFromDB = connectDB.GetDataRiver(); ;
            foreach (var item in getDataFromDB)
            {
                 var count = 0;
                count++;
                var itemID = item.RIVERCODE.ToString();
                var id = itemID.Substring(1);
                var dataForRiver = connectDB.FindDataForRiver(id);

                var riverIndex = new ProcressRiver();
                var resultIndex = riverIndex.Procress(item, dataForRiver);
                connectDB.InsertRiverIndexToDB(resultIndex);

                var riverPoint = new ProcressRiverPoint();
                var resultPoint = riverPoint.Procress(resultIndex);
                connectDB.InsertRiverPointToDB(resultPoint);
                
                System.Console.WriteLine(count);
            }
        }
    }
}
