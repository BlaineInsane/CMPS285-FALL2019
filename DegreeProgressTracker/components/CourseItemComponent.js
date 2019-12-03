import React, { Component } from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';
import { MaterialCommunityIcons } from '@expo/vector-icons';

class CourseItemComponent extends Component {

    state = {
        toggle: false
    }

    _onPress() {
        const newState = !this.state.toggle;
        this.setState({ toggle: newState })
    }

    render() {
        const { toggle } = this.state;
        const iconValue = toggle ? "checkbox-marked" : "plus-box-outline";


        return (
            <View>
                <View>
                    <TouchableOpacity
                        onPress={() => this._onPress()}>
                        <View style={styles.container}>
                            <View paddingTop={10}><Text style={styles.text}>{this.props.course}</Text></View>
                            <View paddingTop={3} paddingRight={5}><MaterialCommunityIcons name={iconValue} size={32} color="white" /></View>
                        </View>

                    </TouchableOpacity>
                </View>
            </View>
        );
    };
};

const CourseItem = props => {
    return (
        <CourseItemComponent course={props.title} />
    );
}

const styles = StyleSheet.create({

    container: {
        alignSelf: 'center',
        height: 40,
        width: '100%',
        backgroundColor: 'grey',
        paddingLeft: 5,
        justifyContent: 'space-between',
        shadowColor: "#000",
        shadowOffset: {
            width: 0,
            height: 5,
        },
        shadowOpacity: 0.34,
        shadowRadius: 6.27,
        elevation: 10,
        flexDirection: "row",
    },
    text: {
        color: 'white',
        fontWeight: 'bold',
        textTransform: 'uppercase'
    },

});

export default CourseItem;