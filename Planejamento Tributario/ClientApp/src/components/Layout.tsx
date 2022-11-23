import * as React from 'react';
// import { Container } from 'reactstrap';
import NavMenu from './NavMenu';

export default (props: { children?: React.ReactNode }) => (
    <React.Fragment>
        <NavMenu/>
        <div style={{ 'padding':'50px 100px 50px 100px' }}>
            {props.children}
        </div>
    </React.Fragment>
);
