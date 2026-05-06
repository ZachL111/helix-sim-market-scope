# Helix Sim Market Scope Walkthrough

This note is the quickest way to read the extra review model in `helix-sim-market-scope`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 194 | ship |
| stress | state drift | 197 | ship |
| edge | review cost | 179 | ship |
| recovery | decision risk | 185 | ship |
| stale | input pressure | 201 | ship |

Start with `stale` and `edge`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The next useful expansion would be a malformed fixture around state drift and decision risk.
