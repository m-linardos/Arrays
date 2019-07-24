using System;

namespace ArraysProj {
    class Program {
        static void Main(string[] args) {
            int[] frames = new int[30];         // name should be plural  
            frames[0] = 10;                                     //[INDEX]
            frames[1] = 7;
            frames[2] = 5;                      // loop through the collection until bool expresn is true
            frames[3] = 10;                     
            frames[4] = 9;
            frames[5] = 8;
            frames[6] = 10;
            frames[7] = 2;
            frames[8] = 6;
            frames[9] = 10;
            frames[10] = 2;                                     //[INDEX]
            frames[11] = 7;
            frames[12] = 5;                      // loop through the collection until bool expresn is true
            frames[13] = 10;
            frames[14] = 9;
            frames[15] = 8;
            frames[16] = 10;
            frames[17] = 0;
            frames[18] = 6;
            frames[19] = 2;
            frames[20] = 10;                                     //[INDEX]
            frames[21] = 5;
            frames[22] = 5;                      // loop through the collection until bool expresn is true
            frames[23] = 10;
            frames[24] = 7;
            frames[25] = 0;
            frames[26] = 1;
            frames[27] = 2;
            frames[28] = 8;
            frames[29] = 10;

            // FIND Bowling Score  /  // use while frames < 10

            int total = 0;
            int index = 0;
            // while(<index is less than items in array>)
            while ( index < 30) {
                total = total + frames[index];                // 1st loop starts with index 0
                index = index + 1;
            }
            Console.WriteLine($"Total is {total}");         // Goes to this line when bool expres. is FALSE




        }
    }
}
