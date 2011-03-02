String.prototype.format = function() {
    var formatted = this;
    for(var i = 0; i < arguments.length; i+=1) {
        formatted = formatted.replace("{" + i + "}", arguments[i]);
    }
    return formatted;
};

Array.prototype.findFirst = function(f) {
  for(var i = 0; i < this.length; i+=1) {
    if(f(this[i])) {
      return this[i];
    }
  }
};

Array.prototype.filter = function(f) {
  var result = [];
  for(var i = 0; i < this.length; i+=1) {
    if(f(this[i])) {
      result.push(this[i]);
    }
  }
  return result;
};

Array.prototype.fold = function(f, zero) {
    var result = zero;
    for(var i = 0; i < this.length; i+=1) {
        result = f(result, this[i]);
    }
    return result;
};

Array.prototype.map = function(f) {
    return fold([], function(acc, current) {
        acc.push(f(current));
    })
};


