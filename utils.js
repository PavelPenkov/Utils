String.prototype.format = function() {
    var formatted = this;
    for(var i = 0; i < arguments.length; i+=1) {
      var r = new RegExp("\\{" + i + "\\}", "g");
      formatted = formatted.replace(r, arguments[i]);
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

Array.prototype.fold = function(zero, f) {
    var result = zero;
    for(var i = 0; i < this.length; i+=1) {
        result = f(result, this[i]);
    }
    return result;
};

Array.prototype.map = function(f) {
  var result = [];
  for(var i = 0; i < this.length; i+= 1) {
    result.push(f.apply(this[i]));
  }
  return result;
};

Array.prototype.indexOf = function(f) {
  for(var i = 0; i < this.length; i+=1) {
    if(f(this[i])) {
      return i;
    }
  }
  return -1;
}
