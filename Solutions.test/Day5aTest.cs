﻿using Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.test
{
    [TestClass]
    public class Day5aTest
    {
        [TestMethod]
        public void ShouldReturn5()
        {
            var input = @"0
3
0
1
-3";

            var result = new Day5a(input).Solve();

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var input = @"0
2
2
-2
-2
-2
1
2
2
-1
-4
-8
-7
-11
0
-13
-8
-7
-13
-11
-15
-4
-10
-10
-22
-22
-1
-9
1
2
-23
-4
-31
-3
2
-34
-28
-28
-16
-1
-34
-13
-25
1
-14
-40
-11
-32
-25
-17
-43
-23
-3
-52
-31
-8
-15
-48
-13
-56
-37
-24
-25
-47
-38
0
-35
-65
-63
-40
-18
-55
-11
-8
-18
-53
-39
-20
0
-6
-75
-22
-36
-71
-61
-74
-11
-14
-35
-54
-41
-59
-51
-45
-62
-53
-8
-26
-22
-16
-66
-87
-11
-59
-9
-44
-73
-76
-3
-78
-4
-45
-10
-38
-20
-102
-114
-44
-21
-111
-118
0
-80
-65
-28
-51
-95
-42
-31
-41
-98
-39
-89
-116
-115
-30
-68
-52
-21
-17
-92
-136
-24
-16
-13
-110
-10
-44
1
-89
-110
-99
-4
-106
-35
-7
-152
-147
-38
-17
-44
-148
-144
-48
-78
-154
-141
-23
-145
-55
-87
-97
-20
-66
-172
-82
-23
-23
-145
-37
-103
-138
-111
-105
-148
-67
-163
-59
-127
-130
-24
-102
-153
-149
-58
-33
-37
-28
-75
-103
-10
1
-36
-130
-59
-70
-76
-181
-196
-165
-131
-71
-142
-183
-65
-55
-50
-112
-153
-59
-35
-198
-175
-197
-89
-197
-99
-52
-187
-55
-158
-117
-164
-205
-91
-68
-126
-158
-172
-217
-111
-106
-42
-135
-82
-213
-22
-1
-238
-204
-77
-123
-174
-29
-30
-90
-98
-5
-30
-52
-150
-155
-23
-14
-102
-47
-215
-112
-51
-2
0
-62
-138
-255
-227
-17
-114
-34
-28
-139
-226
-258
-18
0
-24
-161
-170
-12
-25
-12
-122
-238
-249
-81
-267
-236
-145
-242
-124
-78
-122
-141
-135
-9
-195
-98
-269
-221
-154
-106
-247
-88
-221
-9
-97
-207
-61
-102
-130
-54
-112
-61
-65
-82
-35
-150
-114
-180
-314
-317
-305
-28
-305
-294
-90
-133
-11
-1
-108
-1
-268
-257
-117
-245
-94
-313
-293
-174
-312
-61
-205
-3
-199
-95
-323
-34
-176
-241
-89
-346
-208
-270
-77
-253
-86
-167
-318
-70
-258
-76
-203
-91
-62
-329
-156
-235
-239
-191
-119
-285
-128
-155
-82
-36
-351
-373
-8
-36
-132
-183
-311
-274
-111
-175
-193
-72
-340
-64
-26
-378
-202
-194
-188
-169
-71
-197
-344
-193
-6
-63
-368
-313
-376
-42
-241
-50
-64
-354
-338
-177
-154
-420
-418
-349
-383
-340
-177
-227
-332
-145
-402
-66
-290
-274
-287
-68
-91
-49
-312
-106
-264
-173
-362
-252
-138
-218
-211
-39
-271
-261
-306
-372
-391
-408
-108
-308
-418
-395
-413
-208
-13
-41
-249
-297
-21
-274
-440
-205
-272
-371
-155
-357
-34
-97
-121
-221
-173
-364
-168
-83
-317
-414
-427
-90
-216
-91
-306
-467
-366
-486
-461
-34
-327
-474
-164
-160
-410
-366
-467
-206
-435
-167
-326
-423
-241
-45
-18
-59
-498
-483
-380
-431
-256
-254
-415
-18
-461
-223
-152
-179
-8
-169
-41
-452
-302
-172
-249
-5
-40
-97
-39
-492
-40
-460
-276
-442
-413
-220
-376
-389
-446
-133
-228
-364
-215
-133
-304
-234
-275
-463
-267
-147
-162
-227
-532
-216
-479
-61
-409
-376
-389
-283
-332
-97
-66
-486
-223
-522
-359
-340
-211
-401
-98
-249
-511
-238
-72
-473
-132
-450
-321
-455
-451
-140
-495
-212
-235
-213
-22
-111
-236
-390
-104
-230
-569
-45
-43
-264
-561
-552
-32
-403
-17
-288
-255
-436
-363
-495
-19
-358
-250
-59
-172
-77
-558
-211
-555
-65
-419
-282
-472
-72
-462
-276
-508
-489
-184
-486
-500
-143
-627
-506
-84
-368
-355
-467
-515
-415
-314
-386
-114
-319
-237
-113
-611
-17
-532
-181
-568
-132
-178
-276
-258
-384
-295
-208
-471
-622
-173
-531
-192
-231
-338
-427
-416
-591
-112
-511
-538
-357
-189
-186
-100
-458
-331
-85
-294
-375
-206
-377
-92
-504
-558
-26
-73
-103
-455
-397
-164
-683
-615
-321
-310
-76
-576
-291
-523
-163
-452
-236
-488
-588
-24
-52
-673
-176
-282
-642
-668
-517
-575
-173
-517
-565
-385
-202
-587
-519
-694
-493
-181
-241
-630
-597
-377
-560
-646
-100
-544
-135
-695
-460
-621
-97
-376
-511
-413
-613
-238
-160
-141
-329
-682
-664
-439
-730
-646
-266
-477
-233
-722
-687
-605
-483
-648
-685
-735
-739
-630
-644
-498
-652
-493
-508
-108
-32
-620
-185
-422
-187
-112
-263
-568
-599
-751
-768
-640
-440
-451
-760
-156
-425
-662
-764
-503
-521
-140
-425
-72
-242
-403
-778
-689
-693
-541
-674
-93
-545
-601
-730
-305
-743
-563
-315
-637
-126
-260
-463
-309
-538
-59
-368
-382
-355
-414
-97
-93
-475
-445
-319
-783
-411
-338
-480
-755
-149
-821
-813
-229
-116
-488
-741
-669
-442
-627
-403
-129
-829
-664
-357
-686
-835
-172
-80
-367
-789
-573
-199
-795
-221
-177
-543
-117
-651
-382
-731
-842
-125
-397
-328
-69
-388
-381
1
-737
-199
-181
-264
-577
-63
-616
-333
-413
-616
-189
-315
-237
-608
-497
-348
-285
-863
-97
-745
-716
-666
-165
-522
-631
-438
-639
-443
-122
-521
-48
-501
-895
-205
-57
-576
-644
-442
-143
-215
-661
-749
-247
-298
-387
-601
-525
-383
-9
-64
-416
-423
-522
-631
-890
-867
-649
-525
-228
-544
-54
-878
-277
-924
-838
-885
-477
-256
-330
-301
-815
-722
-646
-677
-70
-917
-126
-832
-479
-849
-591
-66
-260
-524
-603
-86
-397
-63
-299
-417
-375
-909
-489
-872
-930
-638
-280
-440
-788
-818
-398
-765
-229
-346
-864
-155
-57
-686
-850
-84
-783
-191
-923
-740
-454
-118
-807
-662
-859
-99
-139
-272
-640
-166
-935
-805
-351
-413
-467
-535
-377
-97
-204
-262
-4
-704
-516
-459
-702
-718
-241
-534
-318
-955
-519
-675
-766
-671
-843
-861
-214
-4
-828
-638
-833
-953
-521
-17
-87
-393
-951
-17
-529
-49
-299
-673
-119
-185
-601
-187
-399
-646
-812
-627
-121
-535
-155
-601
-196
-365
-366
-409
-596
-803
-508
-988
-529
-925";

            var result = new Day5a(input).Solve();

            Assert.AreEqual(359348, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var input = @"0
2
2
-1
-1
-4
-2
-6
-2
-8
1
-8
0
-11
-3
0
-11
-2
-8
-4
-13
-14
-4
-13
-14
0
-6
-26
-11
-10
-4
-8
-2
-29
-22
-6
-8
-31
-32
-31
-24
-9
-9
1
-41
1
-27
-4
1
-1
-23
2
-6
-14
-46
-14
-4
-48
-22
-29
-56
-8
-10
-16
-2
-32
-3
0
-26
1
-10
-40
-16
-9
-7
-14
-10
-49
-33
-9
-60
-59
0
-67
-19
-13
-74
-76
-64
-73
-4
-26
-24
-30
-72
-78
-13
-17
-6
-13
-1
-89
-78
-18
-48
-56
1
-69
-45
-25
-54
-11
1
-10
-105
-15
-11
-75
-89
-96
-63
-5
-20
-45
-111
-123
0
-119
-21
-18
-31
-10
0
-91
-94
-129
-105
-126
0
-6
-116
-72
-34
-61
-7
-34
-125
-17
-60
-111
-86
-72
-72
-88
-118
-54
-117
-136
-144
-10
-150
-2
-148
-123
-109
-125
-36
-163
-150
0
-68
-126
-11
-159
-92
-50
-9
-127
-158
-58
0
-152
-157
-67
-63
-109
-141
-116
-1
-143
-107
-82
-50
-106
-175
-40
-103
-76
-20
-55
-118
-20
-145
-31
-117
-203
-30
-47
-49
-191
-48
-24
-132
-27
-80
-97
-63
-41
-36
-113
-89
-26
-9
-218
-137
-196
-97
-219
-144
-129
-159
2
-225
-93
-195
-56
-215
-208
0
-14
-176
-186
-36
-29
-160
-237
-82
-131
-185
-203
-22
-41
-169
-238
-154
-178
-186
-12
-195
-8
-229
-22
-10
-34
-194
-238
-200
-261
-62
-188
-57
-223
-25
-126
-59
-115
-255
-38
-113
-257
-272
-270
-7
-72
-225
-255
-187
-176
-11
-93
-280
-176
-274
-171
-246
-157
-4
-127
-120
-242
-47
-30
-236
-46
-92
-160
-179
-262
-192
-304
-73
-296
-300
-266
-20
-128
-114
-227
-313
-315
-32
-146
-190
-138
-66
-285
-92
-111
-44
-79
-15
-119
-161
-212
-102
-258
-191
-313
-245
-12
-63
-147
-277
-293
0
-112
-136
-201
-228
-334
-283
-91
-232
-323
-126
-271
-128
-101
-296
-235
-320
-232
-285
-329
-158
-120
-77
-98
-197
-225
-42
-208
-139
-332
-74
-186
-202
-236
-250
-5
-320
-293
-25
-107
-326
-55
-260
-64
-354
-110
-345
-286
-318
-81
-244
-49
-324
-36
-390
-14
-147
-386
-160
-307
-74
-31
-122
-188
-301
-171
-274
-97
-386
-106
-205
-63
-10
-263
-132
-321
-153
-20
-138
-136
-416
-44
-280
-312
-248
-143
-399
-244
-77
-323
-217
-339
-55
-287
-384
-2
-144
-330
-400
-248
-402
-348
-434
-192
-324
-24
-400
-161
-196
-185
-28
-278
-345
-440
-400
-125
-158
-165
-15
-360
-166
-459
-97
-99
-116
-406
-251
-164
-91
-100
-200
-324
-215
-380
-314
-463
-80
-126
-193
-13
-379
-319
-136
-117
-28
-389
-473
-418
-170
-13
-134
-411
-119
-135
-373
-487
-241
-445
-76
-418
-91
-28
-281
-405
-4
-359
-209
-5
-8
-174
-340
-315
-439
-396
-446
-510
-329
-292
-413
-11
-163
-91
-496
-471
-360
-32
-412
-411
-434
-163
-70
-223
-364
-275
-522
-411
-207
-122
-527
-42
-343
-241
-443
-327
-128
-273
-224
-248
-435
-406
-514
-326
-437
-156
-323
-233
-544
-212
-206
-460
-430
-123
-61
-49
-246
1
-313
-450
-345
-438
-238
-558
-288
-464
-351
-562
-75
-511
-284
-294
-95
-282
-454
-347
-215
-547
-520
-217
-379
-299
-281
-84
-380
-279
-325
-320
-70
-397
-393
-116
-275
-172
-250
-358
-185
-270
-564
-262
-195
-351
-286
-414
-611
-566
-487
-107
-246
-301
-74
-596
-394
-56
-197
-90
-93
-325
-447
-470
-85
-436
-106
-448
-121
-143
-469
-625
-51
-54
-602
-370
-146
-418
-333
-152
-197
-584
-178
-454
-380
-387
-424
-214
-219
-161
-180
-489
-524
-319
-399
-624
-118
-4
-624
-511
-616
-601
-369
-30
1
-510
-383
-312
-365
-143
-194
-274
-492
-646
-207
-438
-17
-603
-593
-528
-4
-23
-501
-502
-383
-533
-169
-249
-19
-531
-696
-300
-134
-633
-5
-412
-202
-424
-430
-76
-613
-322
-514
-59
-107
-498
-123
-600
-167
-321
-180
-610
-33
-701
-245
-575
-304
-626
-635
-294
-77
-89
-135
-201
-187
-53
-428
-711
-556
-285
-47
-300
-723
-413
-387
-576
-31
-333
-2
-341
-382
-475
-704
-55
-495
-692
-276
-543
-160
-576
-423
-486
-202
-729
-443
-666
-391
-316
-534
-69
-341
-163
-184
-735
-67
-4
-589
-32
-472
-207
-697
-239
-249
-397
-201
-409
-285
-765
-280
-164
-161
-415
-561
-112
-262
-602
-202
-211
-503
-439
-109
-62
-731
-733
-800
-237
-578
-635
-130
-105
-447
-160
-146
-753
-57
-537
-716
-759
-750
-635
-713
-762
-58
-405
-810
-592
-733
-383
-745
-43
-729
-168
-612
-134
-513
-557
-635
-93
-484
-800
-443
-127
-669
-11
-239
-812
-703
-615
-776
-668
-50
-665
-544
-156
-536
-511
-81
-397
-698
-478
-671
-389
-93
-142
-711
-290
-811
-257
-636
-683
-42
-89
-703
-343
-599
-47
-563
-296
-417
-168
-536
-802
-584
-861
-613
-696
-793
-313
-39
-167
-47
-3
-467
-844
-838
-261
-873
-197
-278
-700
-731
-819
-630
-207
-294
-208
-198
-586
-216
-671
-706
-862
-3
-891
-674
-489
-885
-523
-876
-876
-199
-174
-139
-485
-234
-879
-570
-1
-480
-615
-919
-409
-681
-194
-341
-426
-630
-135
-700
-548
-201
-800
-866
-100
-162
-530
-772
-901
-796
-86
-124
-21
-874
-846
-11
-643
-539
-40
-68
-761
-319
-544
-881
-349
-882
-371
-289
-162
-709
-331
-660
-189
-72
-902
-929
-581
-437
-136
-197
-88
-174
-965
-954
-490
-774
-798
-420
-243
-819
-214
-639
-266
-413
-452
-231
-485
-545
-365
-860
-23
-364
-484
-699
-476
-988
-135
-686
-1002
-212
-586
-604
-714
-321
-498
-538
-151
-635
-441
-843
-537
-363
-709
1
-176
-750
-265
-919
-939
-369
-503
-284
-362
-258
-16
-970
-822
-673
-193
-491
-143
-698
-636
-620
-943
-538
-696
-504
-238
-129
-408
-846
-880
-926
-808
-758
-990
-879
-888
-972
-948
-662
-90
-1014
-469
-405
-654
-743
-733";
            var result = new Day5a(input).Solve();

            Assert.AreEqual(376976, result);
        }
    }
}