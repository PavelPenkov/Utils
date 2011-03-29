module Enumerable
  def group(key_selector = nil, value_selector = nil, &block)
    key_selector ||= block
    value_selector ||= lambda{|x| x}
    result = {}
    self.each do |x|
      key = key_selector.call(x)
      values = self.select {|y| key_selector.call(y) == key}
      result[key] = values.map {|x| value_selector.call(x)}
    end
    result
  end
end


