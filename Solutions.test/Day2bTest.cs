using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day2bTest
    {
        [TestMethod]
        public void ShouldReturn9ForExample1()
        {
            var exampleInput = @"5 9 2 8
9 4 7 3
3 8 6 5";
            var result = new Day2b(exampleInput).Solve();

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EvenlyDivideShouldThrowExceptionForEmptyRow()
        {
            var testInput = new int[0];

            new EvenlyDivide(testInput).FindEvenQuotient();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EvenlyDivideShouldThrowExceptionForRowWith1Element()
        {
            var testInput = new int[] {1};

            new EvenlyDivide(testInput).FindEvenQuotient();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EvenlyDivideShouldThrowExceptionForNullRow()
        {
            new EvenlyDivide(null).FindEvenQuotient();
        }

        [TestMethod]
        public void EvenlyDivideShouldReturn0WhenNoDivisibleEntriesFound()
        {
            var testInput = new int[] { 2, 5 };

            var result = new EvenlyDivide(testInput).FindEvenQuotient();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void EvenlyDivideShouldReturn1For2and2()
        {
            var testInput = new int[] { 2, 2 };

            var result = new EvenlyDivide(testInput).FindEvenQuotient();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EvenlyDivideShouldReturn2For2and4()
        {
            var testInput = new int[] { 2, 4 };

            var result = new EvenlyDivide(testInput).FindEvenQuotient();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void EvenlyDivideShouldReturn1For2_5_2()
        {
            var testInput = new int[] { 2, 5, 2 };

            var result = new EvenlyDivide(testInput).FindEvenQuotient();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubmittedResult()
        {
            var input = @"798	1976	1866	1862	559	1797	1129	747	85	1108	104	2000	248	131	87	95
201	419	336	65	208	57	74	433	68	360	390	412	355	209	330	135
967	84	492	1425	1502	1324	1268	1113	1259	81	310	1360	773	69	68	290
169	264	107	298	38	149	56	126	276	45	305	403	89	179	394	172
3069	387	2914	2748	1294	1143	3099	152	2867	3082	113	145	2827	2545	134	469
3885	1098	2638	5806	4655	4787	186	4024	2286	5585	5590	215	5336	2738	218	266
661	789	393	159	172	355	820	891	196	831	345	784	65	971	396	234
4095	191	4333	161	3184	193	4830	4153	2070	3759	1207	3222	185	176	2914	4152
131	298	279	304	118	135	300	74	269	96	366	341	139	159	17	149
1155	5131	373	136	103	5168	3424	5126	122	5046	4315	126	236	4668	4595	4959
664	635	588	673	354	656	70	86	211	139	95	40	84	413	618	31
2163	127	957	2500	2370	2344	2224	1432	125	1984	2392	379	2292	98	456	154
271	4026	2960	6444	2896	228	819	676	6612	6987	265	2231	2565	6603	207	6236
91	683	1736	1998	1960	1727	84	1992	1072	1588	1768	74	58	1956	1627	893
3591	1843	3448	1775	3564	2632	1002	3065	77	3579	78	99	1668	98	2963	3553
2155	225	2856	3061	105	204	1269	171	2505	2852	977	1377	181	1856	2952	2262";
            var result = new Day2b(input).Solve();

            Assert.AreEqual(303, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var input = @"6046	6349	208	276	4643	1085	1539	4986	7006	5374	252	4751	226	6757	7495	2923
1432	1538	1761	1658	104	826	806	109	939	886	1497	280	1412	127	1651	156
244	1048	133	232	226	1072	883	1045	1130	252	1038	1022	471	70	1222	957
87	172	93	73	67	192	249	239	155	23	189	106	55	174	181	116
5871	204	6466	6437	5716	232	1513	7079	6140	268	350	6264	6420	3904	272	5565
1093	838	90	1447	1224	744	1551	59	328	1575	1544	1360	71	1583	75	370
213	166	7601	6261	247	210	4809	6201	6690	6816	7776	2522	5618	580	2236	3598
92	168	96	132	196	157	116	94	253	128	60	167	192	156	76	148
187	111	141	143	45	132	140	402	134	227	342	276	449	148	170	348
1894	1298	1531	1354	1801	974	85	93	1712	130	1705	110	314	107	449	350
1662	1529	784	1704	1187	83	422	146	147	1869	1941	110	525	1293	158	1752
162	1135	3278	1149	3546	3686	182	149	119	1755	3656	2126	244	3347	157	865
2049	6396	4111	6702	251	669	1491	245	210	4314	6265	694	5131	228	6195	6090
458	448	324	235	69	79	94	78	515	68	380	64	440	508	503	452
198	216	5700	4212	2370	143	5140	190	4934	539	5054	3707	6121	5211	549	2790
3021	3407	218	1043	449	214	1594	3244	3097	286	114	223	1214	3102	257	3345";
            var result = new Day2b(input).Solve();

            Assert.AreEqual(267, result);
        }
    }
}
