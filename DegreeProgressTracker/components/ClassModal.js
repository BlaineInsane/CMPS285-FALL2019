import React, { Component } from 'react';
import { View, Image, Text, Button, StyleSheet } from 'react-native';
import Modal from 'react-native-modal';

export default class ClassModal extends Component {
    state = {
        isModalVisible: true
    };
  
    toggleModal = () => {
        this.setState({ isModalVisible: !this.state.isModalVisible });
    };
  
    render() {
        return (
            <View style={{ flex: 1 }}>
                <Button title="Show modal" onPress={this.toggleModal} />
                    <Modal 
                        isVisible={this.state.isModalVisible}
                        onBackdropPress={() => this.setState({ isModalVisible: false })}
                    >
                        <View style={{ flex: 1 }}>
                            <Text>Hello!</Text>
                            <Button title="Hide modal" onPress={this.toggleModal} />
                        </View>
                    </Modal>
            </View>
      );
    }
}

{/*
const ClassModal = props => (
    <Modal style={styles.modalContainer}
        isVisible ={true}
        backdropColor = {'white'}
    >
        <View>
            <Text>IN THE MODAL BABY</Text>
        </View>
    </Modal>
);

state = {
    isModalVisible: false
};

const toggleModal = () => {
    this.setState({ isModalVisible: !this.StaticRange.isModalVisible });
}

const styles = StyleSheet.create({
    
    modalContainer: {
        height: '80%',
        width: '80%',
        flex: 1,
    }
})

export default ClassModal;
*/}