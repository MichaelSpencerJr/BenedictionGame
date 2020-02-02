Feature: Merge Rules
	As a player, I should see that merge rules are applied correctly.  Cursed pieces cannot
	merge with other non-blessed pieces.  Merges must not exceed stack size 2 unless one
	piece involved in the merge is blessed.  Merges remove blessings and curses.

Scenario: Merge Happy Path


Scenario: Merge Maximum


Scenario: Merge Normal and Normal


Scenario: Merge Above Size Two Requires Blessing


Scenario: Merge Normal and Blessed


Scenario: Merge Cursed and Blessed


Scenario: Cannot Merge Cursed and Normal


Scenario: Cannot Merge Cursed and Cursed


Scenario: Merge Normal and King


Scenario: Merge Normal and King Above Stack Size Two Requires Blessing


Scenario: Merge Blessed and King


Scenario: Cannot Merge Cursed and King


Scenario: Cannot Merge King and King


Scenario: Cannot Merge Above Stack Size Fifteen
