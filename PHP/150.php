<?php

class Solution
{
    public function evalRPN(array $tokens): int
    {
        $nums = [];

        foreach ($tokens as $t) {
            if (is_numeric($t)) {
                $nums[] = $t;
            } else {
                $val1 = array_pop($nums);
                $val2 = array_pop($nums);

                $res = match ($t) {
                    '+' => $val1 + $val2,
                    '-' => $val2 - $val1,
                    '*' => $val1 * $val2,
                    '/' => intdiv($val2, $val1)
                };

                $nums[] = $res;
            }
        }

        return $nums[0];
    }
}
