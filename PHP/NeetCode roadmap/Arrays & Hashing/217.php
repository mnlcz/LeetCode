<?php

class Solution
{
    public function containsDuplicate(array $nums): bool
    {
        $set = [];
        foreach ($nums as $num) {
            if (array_key_exists($num, $set)) {
                return true;
            }

            $set[$num] = true;
        }

        return false;
    }
}
