<?php

class MinStack
{
    private array $contents = [];

    private array $mins = [];

    public function __construct()
    {
    }

    public function push(int $val): void
    {
        $this->contents[] = $val;

        if (empty($this->mins)) {
            $this->mins[] = $val;
        } else {
            $this->mins[] = min($val, end($this->mins));
        }
    }

    public function pop(): void
    {
        array_pop($this->contents);
        array_pop($this->mins);
    }

    public function top(): int
    {
        return end($this->contents);
    }

    public function getMin(): int
    {
        return end($this->mins);
    }
}
