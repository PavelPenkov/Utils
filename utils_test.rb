require 'test/unit'
require 'utils'

class TestUtils < Test::Unit::TestCase
  def test_grouping_arrays
    persons = [['F', 'Alice'], ['F', 'Barbra'], ['M', 'Carl']]
    groups = persons.group(lambda {|x| x[0]})
    assert_equal(2, groups['F'].length)
    assert_equal(1, groups['M'].length)
  end

  def test_grouping_values
    persons = [['F', 'Alice'], ['F', 'Barbra'], ['M', 'Carl']]
    groups = persons.group(lambda {|x| x[0]}, lambda {|x| x[1]})
    assert_equal('Carl', groups['M'][0])
  end

  def test_grouping_with_block
    persons = [['F', 'Alice'], ['F', 'Barbra'], ['M', 'Carl']]
    groups = persons.group {|p| p[0]}
    assert_equal(2, groups['F'].length)
    assert_equal(1, groups['M'].length)
  end
end

