import { AbstractControl } from "@angular/forms";

export function createCompareValidator(controlOne: AbstractControl, controlTwo: AbstractControl) {
    return () => {
    if (controlOne.value !== controlTwo.value)
      return { match_error: 'Value does not match' };
    return null;
  };

}