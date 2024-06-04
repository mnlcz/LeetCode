<?php

class Solution
{
    private array $pairs = ['(' => ')', '[' => ']', '{' => '}'];

    public function isValid(string $s): bool
    {
        if (strlen($s) % 2 !== 0) {
            return false;
        }

        $openings = [];
        $chars = str_split($s);

        foreach ($chars as $char) {
            if ($this->isOpening($char)) {
                $openings[] = $char;
            } else {
                if (empty($openings)) {
                    return false;
                }
                $op = array_pop($openings);
                if ($this->pairs[$op] !== $char) {
                    return false;
                }
            }
        }

        return empty($openings);
    }

    private function isOpening(string $ch): bool
    {
        return $ch === '(' || $ch === '[' || $ch === '{';
    }
}
