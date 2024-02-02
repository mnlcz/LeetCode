<?php

class Solution
{
    public function longestConsecutive(array $nums): int
    {
        if (empty($nums)) {
            return 0;
        }

        $numSet = array_flip($nums);
        $longest = 0;

        foreach ($numSet as $num => $_) {
            if (! array_key_exists($num - 1, $numSet)) {
                $currentNum = $num;
                $currentSeq = 1;

                while (array_key_exists($currentNum + 1, $numSet)) {
                    $currentNum++;
                    $currentSeq++;
                }

                $longest = max($longest, $currentSeq);
            }
        }

        return $longest;
    }
}
