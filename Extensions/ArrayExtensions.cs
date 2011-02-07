namespace Extensions {
    using System;

    public static class ArrayExtensions {
        public static int Push<T>(ref T[] array, T item) {
            var len = array.Length;
            var res = new T[len + 1];

            array.CopyTo(res, 0);
            array = res;
            array[len] = item;

            return array.Length;
        }

        public static T Pop<T>(ref T[] array) {
            var len = array.Length;
            var res = new T[len - 1];
            var popped = array[len - 1];

            if (len > 1) 
                for (var i = 0; i < len - 1; i++) 
                    res[i] = array[i];

            array = res;

            return popped;
        }

        public static T Shift<T>(ref T[] array) {
            var len = array.Length;
            var res = new T[len - 1];
            var shifted = array[0];

            while (len > 1)
                res[--len - 1] = array[len];

            array = res;

            return shifted;
        }

        public static T[] Splice<T>(ref T[] array, int index, int length, params T[] args) {
            throw new NotImplementedException();
        }

        public static dynamic[] Map<T>(this T[] array, Func<T, dynamic> fun) {
            if (array == null) {
                throw new ArgumentNullException("array");
            }

            var len = array.Length;
            var res = new dynamic[len];

            for (var i = 0; i < len; i++) {
                var item = array[i];
                res[i] = fun.Invoke(item);
            }

            return res;
        }

        public static T[] Filter<T>(this T[] array, Func<T, bool> fun) {
            if (array == null) {
                throw new ArgumentNullException("array");
            }

            var len = array.Length;
            var res = new T[] {};

            for (var i = 0; i < len; i++) {
                var value = array[i];

                if (fun.Invoke(value)) 
                    Push(ref res, value);
            }

            return res;
        }

        public static string Join(this string[] array, string separator) {
            if (array == null) throw new ArgumentNullException("array");

            return String.Join(separator, array);
        }
    }
}