
## List
```
    Movies = _context.Movies.ToList();
```

## Detail
```
    Movie = _context.Movies.FirstOrDefault(n => n.Id == id);
```


## Add
```
    _context.Movies.Add(movie);
    _context.SaveChanges();
```
