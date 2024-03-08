<?php

class Solution
{
    public function isAnagram(string $s, string $t): bool
    {
        $len = strlen($s);

        if ($len !== strlen($t)) {
            return false;
        }

        $letters1 = [];
        $letters2 = [];

        for ($i = 0; $i < $len; $i++) {
            $ch1 = $s[$i];
            $ch2 = $t[$i];

            $letters1[$ch1] = array_key_exists($ch1, $letters1) ? $letters1[$ch1] + 1 : 1;
            $letters2[$ch2] = array_key_exists($ch2, $letters2) ? $letters2[$ch2] + 1 : 1;
        }

        foreach ($letters1 as $letter => $reps) {
            if (! array_key_exists($letter, $letters2) || $reps !== $letters2[$letter]) {
                return false;
            }
        }

        return true;
    }
}
