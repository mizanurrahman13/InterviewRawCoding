using MergeOverlappingInterval;

var mergeOverlappingIntervals = new MergeOverlappingIntervals();

Interval[] array = new Interval[4];

array[0] = new Interval(6, 8);
array[1] = new Interval(1, 9);
array[2] = new Interval(2, 4);
array[3] = new Interval(4, 7);

mergeOverlappingIntervals.MergeIntervals(array);