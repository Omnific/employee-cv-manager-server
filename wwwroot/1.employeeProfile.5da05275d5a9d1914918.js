webpackJsonp([1],{

/***/ 395:
/***/ function(module, exports, __webpack_require__) {

	'use strict';
	
	Object.defineProperty(exports, "__esModule", {
	  value: true
	});
	
	var _getPrototypeOf = __webpack_require__(333);
	
	var _getPrototypeOf2 = _interopRequireDefault(_getPrototypeOf);
	
	var _classCallCheck2 = __webpack_require__(337);
	
	var _classCallCheck3 = _interopRequireDefault(_classCallCheck2);
	
	var _createClass2 = __webpack_require__(338);
	
	var _createClass3 = _interopRequireDefault(_createClass2);
	
	var _possibleConstructorReturn2 = __webpack_require__(339);
	
	var _possibleConstructorReturn3 = _interopRequireDefault(_possibleConstructorReturn2);
	
	var _inherits2 = __webpack_require__(357);
	
	var _inherits3 = _interopRequireDefault(_inherits2);
	
	var _react = __webpack_require__(2);
	
	var _react2 = _interopRequireDefault(_react);
	
	var _reactRedux = __webpack_require__(365);
	
	var _PropTypes = __webpack_require__(386);
	
	var _Spinner = __webpack_require__(390);
	
	var _Spinner2 = _interopRequireDefault(_Spinner);
	
	var _Error = __webpack_require__(392);
	
	var _Error2 = _interopRequireDefault(_Error);
	
	var _employeeProfile = __webpack_require__(396);
	
	function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }
	
	// PropTypes
	var EmployeeProfile = function (_Component) {
	  (0, _inherits3.default)(EmployeeProfile, _Component);
	
	  function EmployeeProfile() {
	    (0, _classCallCheck3.default)(this, EmployeeProfile);
	    return (0, _possibleConstructorReturn3.default)(this, (EmployeeProfile.__proto__ || (0, _getPrototypeOf2.default)(EmployeeProfile)).apply(this, arguments));
	  }
	
	  (0, _createClass3.default)(EmployeeProfile, [{
	    key: 'componentWillMount',
	    value: function componentWillMount() {
	      var _props = this.props;
	      var selectEmployee = _props.selectEmployee;
	      var employeeId = _props.params.employeeId;
	
	
	      selectEmployee(employeeId);
	    }
	  }, {
	    key: 'render',
	    value: function render() {
	      var hasLoaded = this.props.hasLoaded;
	
	      if (!hasLoaded) {
	        return _react2.default.createElement(_Spinner2.default, null);
	      }
	
	      var _props2 = this.props;
	      var hasError = _props2.hasError;
	      var error = _props2.error;
	
	      if (hasError) {
	        return _react2.default.createElement(_Error2.default, { error: error });
	      }
	
	      // deconstruct the employee object for easier rendering
	      var _props$employee = this.props.employee;
	      var firstName = _props$employee.firstName;
	      var lastName = _props$employee.lastName;
	      var role = _props$employee.role;
	      var team = _props$employee.team;
	      var biography = _props$employee.biography;
	      var avatar = _props$employee.avatar;
	      var keySkills = _props$employee.keySkills;
	      var recentProjects = _props$employee.recentProjects;
	
	      return _react2.default.createElement(
	        'div',
	        null,
	        _react2.default.createElement(
	          'div',
	          { className: 'col s12 m4' },
	          _react2.default.createElement(
	            'div',
	            { className: 'row' },
	            _react2.default.createElement(
	              'div',
	              { className: 'profile' },
	              _react2.default.createElement(
	                'div',
	                { className: 'col s12 m6 profile-picture' },
	                _react2.default.createElement('img', { src: avatar, alt: '' })
	              ),
	              _react2.default.createElement(
	                'div',
	                { className: 'col s12 m6 profile-details' },
	                _react2.default.createElement(
	                  'h5',
	                  { className: 'profile-name' },
	                  firstName,
	                  ' ',
	                  lastName
	                ),
	                _react2.default.createElement(
	                  'label',
	                  null,
	                  'Role'
	                ),
	                _react2.default.createElement(
	                  'span',
	                  { className: 'profile-role' },
	                  role
	                ),
	                _react2.default.createElement(
	                  'label',
	                  null,
	                  'Team'
	                ),
	                _react2.default.createElement(
	                  'span',
	                  { className: 'profile-team' },
	                  team
	                )
	              )
	            )
	          ),
	          _react2.default.createElement(
	            'div',
	            { className: 'row' },
	            _react2.default.createElement(
	              'div',
	              { className: 'profile' },
	              _react2.default.createElement(
	                'div',
	                { className: 'col s12 m12 profile-details' },
	                _react2.default.createElement(
	                  'h5',
	                  { className: 'profile-name' },
	                  'Key Skills and Technologies'
	                ),
	                _react2.default.createElement(
	                  'ul',
	                  { className: 'collection' },
	                  keySkills.map(function (skill) {
	                    return _react2.default.createElement(
	                      'li',
	                      { key: skill.name, className: 'collection-item' },
	                      skill.name
	                    );
	                  })
	                )
	              )
	            )
	          )
	        ),
	        _react2.default.createElement(
	          'div',
	          { className: 'col s12 m8' },
	          _react2.default.createElement(
	            'h5',
	            null,
	            'Biography'
	          ),
	          _react2.default.createElement(
	            'p',
	            null,
	            biography
	          ),
	          _react2.default.createElement(
	            'h5',
	            null,
	            'Recent Projects'
	          ),
	          _react2.default.createElement(
	            'ul',
	            { className: 'collection' },
	            recentProjects.map(function (project) {
	              return _react2.default.createElement(
	                'li',
	                { key: project.name, className: 'collection-item' },
	                project.name
	              );
	            })
	          )
	        )
	      );
	    }
	  }]);
	  return EmployeeProfile;
	}(_react.Component);
	
	// Actions
	
	
	// Components
	
	
	EmployeeProfile.propTypes = {
	  params: _react.PropTypes.shape({
	    employeeId: _react.PropTypes.string.isRequired
	  }),
	  selectEmployee: _react.PropTypes.func.isRequired,
	  employeeId: _react.PropTypes.string.isRequired,
	  employee: _react.PropTypes.shape(_PropTypes.Employee),
	  hasLoaded: _react.PropTypes.bool.isRequired,
	  hasError: _react.PropTypes.bool.isRequired,
	  error: _react.PropTypes.string
	};
	
	var mapStateToProps = function mapStateToProps(state, ownProps) {
	  return {
	    employeeId: ownProps.params.employeeId,
	    employee: state.employeeProfile.item,
	    hasLoaded: state.employeeProfile.hasLoaded,
	    hasError: state.employeeProfile.hasError,
	    error: state.employeeProfile.error
	  };
	};
	
	var mapDispatchToProps = function mapDispatchToProps(dispatch) {
	  return {
	    selectEmployee: function selectEmployee(employeeId) {
	      return dispatch((0, _employeeProfile.requestEmployee)(employeeId));
	    }
	  };
	};
	
	exports.default = (0, _reactRedux.connect)(mapStateToProps, mapDispatchToProps)(EmployeeProfile);

/***/ },

/***/ 396:
/***/ function(module, exports, __webpack_require__) {

	'use strict';
	
	Object.defineProperty(exports, "__esModule", {
	  value: true
	});
	exports.requestEmployee = exports.employeeErrorReceived = exports.employeeReceived = exports.employeeSelected = undefined;
	
	var _defineProperty2 = __webpack_require__(293);
	
	var _defineProperty3 = _interopRequireDefault(_defineProperty2);
	
	var _assign = __webpack_require__(255);
	
	var _assign2 = _interopRequireDefault(_assign);
	
	var _ACTION_HANDLERS;
	
	exports.default = employeeDashboardReducer;
	
	var _employees = __webpack_require__(297);
	
	function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }
	
	// ------------------------------------
	// Constants
	// ------------------------------------
	var EMPLOYEE_SELECTED = 'EMPLOYEE_SELECTED';
	var EMPLOYEE_RECEIVED = 'EMPLOYEE_RECEIVED';
	var EMPLOYEE_ERROR_RECEIVED = 'EMPLOYEE_ERROR_RECEIVED';
	
	// ------------------------------------
	// Actions
	// ------------------------------------
	var employeeSelected = exports.employeeSelected = function employeeSelected(employeeId) {
	  return {
	    type: EMPLOYEE_SELECTED,
	    employeeId: employeeId
	  };
	};
	
	var employeeReceived = exports.employeeReceived = function employeeReceived(employee) {
	  return {
	    type: EMPLOYEE_RECEIVED,
	    employee: employee
	  };
	};
	
	var employeeErrorReceived = exports.employeeErrorReceived = function employeeErrorReceived(error) {
	  return {
	    type: EMPLOYEE_ERROR_RECEIVED,
	    error: error
	  };
	};
	
	/*  This is a thunk, meaning it is a function that immediately
	    returns a function for lazy evaluation. It is incredibly useful for
	    creating async actions, especially when combined with redux-thunk!
	
	    NOTE: This is solely for demonstration purposes. In a real application,
	    you'd probably want to dispatch an action of COUNTER_DOUBLE and let the
	    reducer take care of this logic.  */
	var requestEmployee = exports.requestEmployee = function requestEmployee(employeeId) {
	  return function (dispatch, getState) {
	    var state = getState();
	    var _state$employeeProfil = state.employeeProfile;
	    var hasLoaded = _state$employeeProfil.hasLoaded;
	    var isFetching = _state$employeeProfil.isFetching;
	
	    if (isFetching || hasLoaded && employeeId === state.employeeProfile.id) return;
	
	    dispatch(employeeSelected(employeeId));
	    return (0, _employees.getEmployee)(employeeId).then(function (employee) {
	      return dispatch(employeeReceived(employee));
	    }, function (error) {
	      return dispatch(employeeErrorReceived(error));
	    });
	  };
	};
	
	// ------------------------------------
	// Action Handlers
	// ------------------------------------
	// ------------------------------------
	var employeeSelectedHandler = function employeeSelectedHandler(state, action) {
	  return (0, _assign2.default)({}, state, {
	    item: null,
	    hasLoaded: false,
	    isFetching: true,
	    hasError: false,
	    error: null
	  });
	};
	
	var employeeRecievedHandler = function employeeRecievedHandler(state, action) {
	  return (0, _assign2.default)({}, state, {
	    item: action.employee,
	    hasLoaded: true,
	    isFetching: false,
	    hasError: false,
	    error: null
	  });
	};
	
	var employeeSelectedErrorHandler = function employeeSelectedErrorHandler(state, action) {
	  return (0, _assign2.default)({}, state, {
	    item: null,
	    hasLoaded: true,
	    isFetching: false,
	    hasError: true,
	    error: action.error
	  });
	};
	
	var ACTION_HANDLERS = (_ACTION_HANDLERS = {}, (0, _defineProperty3.default)(_ACTION_HANDLERS, EMPLOYEE_SELECTED, employeeSelectedHandler), (0, _defineProperty3.default)(_ACTION_HANDLERS, EMPLOYEE_RECEIVED, employeeRecievedHandler), (0, _defineProperty3.default)(_ACTION_HANDLERS, EMPLOYEE_ERROR_RECEIVED, employeeSelectedErrorHandler), _ACTION_HANDLERS);
	
	// ------------------------------------
	// Reducer
	// ------------------------------------
	var initialState = {
	  item: null,
	  hasLoaded: false,
	  isFetching: false,
	  hasError: false,
	  error: null
	};
	
	function employeeDashboardReducer() {
	  var state = arguments.length <= 0 || arguments[0] === undefined ? initialState : arguments[0];
	  var action = arguments[1];
	
	  var handler = ACTION_HANDLERS[action.type];
	
	  return handler ? handler(state, action) : state;
	}

/***/ }

});
//# sourceMappingURL=1.employeeProfile.5da05275d5a9d1914918.js.map