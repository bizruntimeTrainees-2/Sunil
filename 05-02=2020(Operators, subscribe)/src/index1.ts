import { of } from "rxjs";
import{map, first} from 'rxjs/operators'

first()(of(1, 2, 3)).subscribe((v) => console.log(`value: ${v}`));
