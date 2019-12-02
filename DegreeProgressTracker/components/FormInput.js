import React, { Component, Fragment } from 'react';
import { StyleSheet, Text, TextInput, View } from 'react-native';

export default class FormInput extends Component {
  constructor(props) {
    super(props);
    this.state = {
      touched: false,
    };

    this.onBlur = this.onBlur.bind(this);
  }

  renderError() {
    const { errorLabel, touched } = this.props;
    if (errorLabel && (touched || this.state.touched)) {
      return (
        <View>
          <Text style={styles.error}>{errorLabel}</Text>
        </View>
      );
    }
    return null;
  }

  onBlur() {
    this.setState({
      touched: true,
    });
  }

  render() {
    const { label } = this.props;
    var { secure } = this.props;
    return (
      <Fragment>
          <TextInput
            style={styles.input}
            placeholder={label}
            placeholderTextColor="black"
            secureTextEntry={secure}
            {...this.props}
            onBlur={this.onBlur} />
        {this.renderError()}
      </Fragment>
    );
  }
}

const styles = StyleSheet.create({
  input: {
    height: 35,
    width: '100%',
    marginBottom: 10,
    borderWidth: 1,
    alignItems: 'center',
    backgroundColor: 'white',
    borderColor: 'black',
    padding: 10,
    marginBottom: 15,
    alignSelf: 'stretch',
    backgroundColor: 'white',
    justifyContent: 'center',
  },
  error: {
    position: 'absolute',
    bottom: 0,
    color: 'red',
    fontSize: 12,
  },
  inputContainer: {
    alignItems: 'center',
    justifyContent: 'center',
    width: '100%',
  },
});