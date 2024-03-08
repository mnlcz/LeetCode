<?php

class Solution
{
    public function groupAnagrams(array $strs): array
    {
        $groups = [];

        foreach ($strs as $str) {
            $sortedStr = $this->sortString($str);
            $groups[$sortedStr][] = $str;
        }

        return array_values($groups);
    }

    private function sortString(string $str): string
    {
        $chars = str_split($str);

        sort($chars);

        return implode('', $chars);
    }
}
