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
