using System.Runtime.InteropServices;

namespace Yeppp
{

	/// <summary>Basic arithmetic operations</summary>
	public partial class Core
	{


		/// <summary>Computes the minimum of signed 8-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe sbyte Min_V8s_S8s(sbyte[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* v = &vArray[vOffset])
			{
				return Min_V8s_S8s(v, length);
			}
		}


		/// <summary>Computes the minimum of unsigned 8-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe byte Min_V8u_S8u(byte[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* v = &vArray[vOffset])
			{
				return Min_V8u_S8u(v, length);
			}
		}


		/// <summary>Computes the minimum of signed 16-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe short Min_V16s_S16s(short[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* v = &vArray[vOffset])
			{
				return Min_V16s_S16s(v, length);
			}
		}


		/// <summary>Computes the minimum of unsigned 16-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe ushort Min_V16u_S16u(ushort[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* v = &vArray[vOffset])
			{
				return Min_V16u_S16u(v, length);
			}
		}


		/// <summary>Computes the minimum of signed 32-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe int Min_V32s_S32s(int[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* v = &vArray[vOffset])
			{
				return Min_V32s_S32s(v, length);
			}
		}


		/// <summary>Computes the minimum of unsigned 32-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe uint Min_V32u_S32u(uint[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* v = &vArray[vOffset])
			{
				return Min_V32u_S32u(v, length);
			}
		}


		/// <summary>Computes the minimum of signed 64-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe long Min_V64s_S64s(long[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* v = &vArray[vOffset])
			{
				return Min_V64s_S64s(v, length);
			}
		}


		/// <summary>Computes the minimum of unsigned 64-bit integer array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe ulong Min_V64u_S64u(ulong[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ulong* v = &vArray[vOffset])
			{
				return Min_V64u_S64u(v, length);
			}
		}


		/// <summary>Computes the minimum of single precision (32-bit) floating-point array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe float Min_V32f_S32f(float[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* v = &vArray[vOffset])
			{
				return Min_V32f_S32f(v, length);
			}
		}


		/// <summary>Computes the minimum of double precision (64-bit) floating-point array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe double Min_V64f_S64f(double[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* v = &vArray[vOffset])
			{
				return Min_V64f_S64f(v, length);
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 8-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V8sV8s_V8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, sbyte[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (sbyte* minimum = &minimumArray[minimumOffset])
					{
						Min_V8sV8s_V8s(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 8-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V8uV8u_V8u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, byte[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* y = &yArray[yOffset])
				{
					fixed (byte* minimum = &minimumArray[minimumOffset])
					{
						Min_V8uV8u_V8u(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 16-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V16sV16s_V16s(short[] xArray, int xOffset, short[] yArray, int yOffset, short[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (short* minimum = &minimumArray[minimumOffset])
					{
						Min_V16sV16s_V16s(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 16-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V16uV16u_V16u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, ushort[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* y = &yArray[yOffset])
				{
					fixed (ushort* minimum = &minimumArray[minimumOffset])
					{
						Min_V16uV16u_V16u(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 32-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32sV32s_V32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (int* minimum = &minimumArray[minimumOffset])
					{
						Min_V32sV32s_V32s(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 32-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32uV32u_V32u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, uint[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					fixed (uint* minimum = &minimumArray[minimumOffset])
					{
						Min_V32uV32u_V32u(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 64-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64sV32s_V64s(long[] xArray, int xOffset, int[] yArray, int yOffset, long[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (long* minimum = &minimumArray[minimumOffset])
					{
						Min_V64sV32s_V64s(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 64-bit integer arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64uV32u_V64u(ulong[] xArray, int xOffset, uint[] yArray, int yOffset, ulong[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ulong* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					fixed (ulong* minimum = &minimumArray[minimumOffset])
					{
						Min_V64uV32u_V64u(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two single precision (32-bit) floating-point arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32fV32f_V32f(float[] xArray, int xOffset, float[] yArray, int yOffset, float[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					fixed (float* minimum = &minimumArray[minimumOffset])
					{
						Min_V32fV32f_V32f(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two double precision (64-bit) floating-point arrays.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64fV64f_V64f(double[] xArray, int xOffset, double[] yArray, int yOffset, double[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					fixed (double* minimum = &minimumArray[minimumOffset])
					{
						Min_V64fV64f_V64f(x, y, minimum, length);
					}
				}
			}
		}


		/// <summary>Computes pairwise minima of signed 8-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V8sS8s_V8s(sbyte[] xArray, int xOffset, sbyte y, sbyte[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* minimum = &minimumArray[minimumOffset])
				{
					Min_V8sS8s_V8s(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of unsigned 8-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V8uS8u_V8u(byte[] xArray, int xOffset, byte y, byte[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* minimum = &minimumArray[minimumOffset])
				{
					Min_V8uS8u_V8u(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of signed 16-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V16sS16s_V16s(short[] xArray, int xOffset, short y, short[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* minimum = &minimumArray[minimumOffset])
				{
					Min_V16sS16s_V16s(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of unsigned 16-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V16uS16u_V16u(ushort[] xArray, int xOffset, ushort y, ushort[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* minimum = &minimumArray[minimumOffset])
				{
					Min_V16uS16u_V16u(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of signed 32-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32sS32s_V32s(int[] xArray, int xOffset, int y, int[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* minimum = &minimumArray[minimumOffset])
				{
					Min_V32sS32s_V32s(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of unsigned 32-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32uS32u_V32u(uint[] xArray, int xOffset, uint y, uint[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* minimum = &minimumArray[minimumOffset])
				{
					Min_V32uS32u_V32u(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of signed 64-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64sS32s_V64s(long[] xArray, int xOffset, int y, long[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* minimum = &minimumArray[minimumOffset])
				{
					Min_V64sS32s_V64s(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of unsigned 64-bit integer array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64uS32u_V64u(ulong[] xArray, int xOffset, uint y, ulong[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ulong* x = &xArray[xOffset])
			{
				fixed (ulong* minimum = &minimumArray[minimumOffset])
				{
					Min_V64uS32u_V64u(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of single precision (32-bit) floating-point array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V32fS32f_V32f(float[] xArray, int xOffset, float y, float[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* minimum = &minimumArray[minimumOffset])
				{
					Min_V32fS32f_V32f(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of double precision (64-bit) floating-point array elements and a constant.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or minimumArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or minimumArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, minimumOffset is negative, minimumOffset + length exceeds the length of minimumArray, or length is negative.</exception>
		public static unsafe void Min_V64fS64f_V64f(double[] xArray, int xOffset, double y, double[] minimumArray, int minimumOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (minimumOffset + length > minimumArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* minimum = &minimumArray[minimumOffset])
				{
					Min_V64fS64f_V64f(x, y, minimum, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV8sV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					Min_IV8sV8s_IV8s(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 8-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV8uV8u_IV8u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* y = &yArray[yOffset])
				{
					Min_IV8uV8u_IV8u(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV16sV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					Min_IV16sV16s_IV16s(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 16-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV16uV16u_IV16u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* y = &yArray[yOffset])
				{
					Min_IV16uV16u_IV16u(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV32sV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Min_IV32sV32s_IV32s(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 32-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV32uV32u_IV32u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					Min_IV32uV32u_IV32u(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV64sV32s_IV64s(long[] xArray, int xOffset, int[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Min_IV64sV32s_IV64s(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 64-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV64uV32u_IV64u(ulong[] xArray, int xOffset, uint[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ulong* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					Min_IV64uV32u_IV64u(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV32fV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					Min_IV32fV32f_IV32f(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Min_IV64fV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					Min_IV64fV64f_IV64f(x, y, length);
				}
			}
		}


		/// <summary>Computes pairwise minima of signed 8-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV8sS8s_IV8s(sbyte[] xArray, int xOffset, sbyte y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				Min_IV8sS8s_IV8s(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of unsigned 8-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV8uS8u_IV8u(byte[] xArray, int xOffset, byte y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				Min_IV8uS8u_IV8u(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of signed 16-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV16sS16s_IV16s(short[] xArray, int xOffset, short y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				Min_IV16sS16s_IV16s(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of unsigned 16-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV16uS16u_IV16u(ushort[] xArray, int xOffset, ushort y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				Min_IV16uS16u_IV16u(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of signed 32-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV32sS32s_IV32s(int[] xArray, int xOffset, int y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				Min_IV32sS32s_IV32s(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of unsigned 32-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV32uS32u_IV32u(uint[] xArray, int xOffset, uint y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				Min_IV32uS32u_IV32u(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of signed 64-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV64sS32s_IV64s(long[] xArray, int xOffset, int y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				Min_IV64sS32s_IV64s(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of unsigned 64-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV64uS32u_IV64u(ulong[] xArray, int xOffset, uint y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ulong* x = &xArray[xOffset])
			{
				Min_IV64uS32u_IV64u(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of single precision (32-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV32fS32f_IV32f(float[] xArray, int xOffset, float y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				Min_IV32fS32f_IV32f(x, y, length);
			}
		}


		/// <summary>Computes pairwise minima of double precision (64-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Min_IV64fS64f_IV64f(double[] xArray, int xOffset, double y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				Min_IV64fS64f_IV64f(x, y, length);
			}
		}


		/// <summary>Computes the minimum of signed 8-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe sbyte Min_V8s_S8s(sbyte* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			sbyte minimum;
			Status status = yepCore_Min_V8s_S8s(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of unsigned 8-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe byte Min_V8u_S8u(byte* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			byte minimum;
			Status status = yepCore_Min_V8u_S8u(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of signed 16-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe short Min_V16s_S16s(short* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			short minimum;
			Status status = yepCore_Min_V16s_S16s(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of unsigned 16-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe ushort Min_V16u_S16u(ushort* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			ushort minimum;
			Status status = yepCore_Min_V16u_S16u(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of signed 32-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe int Min_V32s_S32s(int* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			int minimum;
			Status status = yepCore_Min_V32s_S32s(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of unsigned 32-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe uint Min_V32u_S32u(uint* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			uint minimum;
			Status status = yepCore_Min_V32u_S32u(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of signed 64-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe long Min_V64s_S64s(long* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			long minimum;
			Status status = yepCore_Min_V64s_S64s(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of unsigned 64-bit integer array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe ulong Min_V64u_S64u(ulong* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			ulong minimum;
			Status status = yepCore_Min_V64u_S64u(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of single precision (32-bit) floating-point array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe float Min_V32f_S32f(float* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			float minimum;
			Status status = yepCore_Min_V32f_S32f(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes the minimum of double precision (64-bit) floating-point array elements.</summary>
		/// <param name="v">Pointer to the array of elements whose minimum will be computed.</param>
		/// <param name="length">Length of the array specified by v. Must be non-zero.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
		public static unsafe double Min_V64f_S64f(double* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			double minimum;
			Status status = yepCore_Min_V64f_S64f(v, out minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return minimum;
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 8-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 8-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V8sV8s_V8s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 8-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 8-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V8uV8u_V8u(byte* x, byte* y, byte* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V8uV8u_V8u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 16-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 16-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V16sV16s_V16s(short* x, short* y, short* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V16sV16s_V16s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 16-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 16-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V16uV16u_V16u(ushort* x, ushort* y, ushort* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V16uV16u_V16u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 32-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32sV32s_V32s(int* x, int* y, int* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32sV32s_V32s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 32-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32uV32u_V32u(uint* x, uint* y, uint* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32uV32u_V32u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 64-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64sV32s_V64s(long* x, int* y, long* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64sV32s_V64s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 64-bit integer arrays.</summary>
		/// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64uV32u_V64u(ulong* x, uint* y, ulong* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64uV32u_V64u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two single precision (32-bit) floating-point arrays.</summary>
		/// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second array of single precision (32-bit) floating-point elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32fV32f_V32f(float* x, float* y, float* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32fV32f_V32f(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two double precision (64-bit) floating-point arrays.</summary>
		/// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second array of double precision (64-bit) floating-point elements.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x, y or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64fV64f_V64f(double* x, double* y, double* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64fV64f_V64f(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 8-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V8sS8s_V8s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 8-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
		/// <param name="y">The unsigned 8-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V8uS8u_V8u(byte* x, byte y, byte* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V8uS8u_V8u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 16-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V16sS16s_V16s(short* x, short y, short* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V16sS16s_V16s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 16-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
		/// <param name="y">The unsigned 16-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V16uS16u_V16u(ushort* x, ushort y, ushort* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V16uS16u_V16u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 32-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32sS32s_V32s(int* x, int y, int* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32sS32s_V32s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 32-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32uS32u_V32u(uint* x, uint y, uint* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32uS32u_V32u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 64-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64sS32s_V64s(long* x, int y, long* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64sS32s_V64s(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 64-bit integer array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64uS32u_V64u(ulong* x, uint y, ulong* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64uS32u_V64u(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of single precision (32-bit) floating-point array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V32fS32f_V32f(float* x, float y, float* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V32fS32f_V32f(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of double precision (64-bit) floating-point array elements and a constant.</summary>
		/// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant.</param>
		/// <param name="minimum">Pointer to the array of pairwise minimum elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and minimum.</param>
		/// <exception cref="System.NullReferenceException">If x or minimum is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or minimum is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_V64fS64f_V64f(double* x, double y, double* minimum, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_V64fS64f_V64f(x, y, minimum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV8sV8s_IV8s(sbyte* x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV8sV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 8-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV8uV8u_IV8u(byte* x, byte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV8uV8u_IV8u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV16sV16s_IV16s(short* x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV16sV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 16-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV16uV16u_IV16u(ushort* x, ushort* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV16uV16u_IV16u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32sV32s_IV32s(int* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32sV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 32-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32uV32u_IV32u(uint* x, uint* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32uV32u_IV32u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64sV32s_IV64s(long* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64sV32s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two unsigned 64-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64uV32u_IV64u(ulong* x, uint* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64uV32u_IV64u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32fV32f_IV32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32fV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64fV64f_IV64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64fV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 8-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV8sS8s_IV8s(sbyte* x, sbyte y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV8sS8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 8-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of unsigned 8-bit integer elements.</param>
		/// <param name="y">The unsigned 8-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV8uS8u_IV8u(byte* x, byte y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV8uS8u_IV8u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 16-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV16sS16s_IV16s(short* x, short y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV16sS16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 16-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of unsigned 16-bit integer elements.</param>
		/// <param name="y">The unsigned 16-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV16uS16u_IV16u(ushort* x, ushort y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV16uS16u_IV16u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 32-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32sS32s_IV32s(int* x, int y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32sS32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 32-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of unsigned 32-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32uS32u_IV32u(uint* x, uint y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32uS32u_IV32u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of signed 64-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64sS32s_IV64s(long* x, int y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64sS32s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of unsigned 64-bit integer array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of unsigned 64-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64uS32u_IV64u(ulong* x, uint y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64uS32u_IV64u(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of single precision (32-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV32fS32f_IV32f(float* x, float y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV32fS32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Computes pairwise minima of double precision (64-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Min_IV64fS64f_IV64f(double* x, double y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Min_IV64fS64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8s_S8s")]
		private static unsafe extern Status yepCore_Min_V8s_S8s(sbyte* v, out sbyte minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8u_S8u")]
		private static unsafe extern Status yepCore_Min_V8u_S8u(byte* v, out byte minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16s_S16s")]
		private static unsafe extern Status yepCore_Min_V16s_S16s(short* v, out short minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16u_S16u")]
		private static unsafe extern Status yepCore_Min_V16u_S16u(ushort* v, out ushort minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32s_S32s")]
		private static unsafe extern Status yepCore_Min_V32s_S32s(int* v, out int minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32u_S32u")]
		private static unsafe extern Status yepCore_Min_V32u_S32u(uint* v, out uint minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64s_S64s")]
		private static unsafe extern Status yepCore_Min_V64s_S64s(long* v, out long minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64u_S64u")]
		private static unsafe extern Status yepCore_Min_V64u_S64u(ulong* v, out ulong minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32f_S32f")]
		private static unsafe extern Status yepCore_Min_V32f_S32f(float* v, out float minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64f_S64f")]
		private static unsafe extern Status yepCore_Min_V64f_S64f(double* v, out double minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8sV8s_V8s")]
		private static unsafe extern Status yepCore_Min_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8uV8u_V8u")]
		private static unsafe extern Status yepCore_Min_V8uV8u_V8u(byte* x, byte* y, byte* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16sV16s_V16s")]
		private static unsafe extern Status yepCore_Min_V16sV16s_V16s(short* x, short* y, short* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16uV16u_V16u")]
		private static unsafe extern Status yepCore_Min_V16uV16u_V16u(ushort* x, ushort* y, ushort* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32sV32s_V32s")]
		private static unsafe extern Status yepCore_Min_V32sV32s_V32s(int* x, int* y, int* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32uV32u_V32u")]
		private static unsafe extern Status yepCore_Min_V32uV32u_V32u(uint* x, uint* y, uint* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64sV32s_V64s")]
		private static unsafe extern Status yepCore_Min_V64sV32s_V64s(long* x, int* y, long* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64uV32u_V64u")]
		private static unsafe extern Status yepCore_Min_V64uV32u_V64u(ulong* x, uint* y, ulong* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32fV32f_V32f")]
		private static unsafe extern Status yepCore_Min_V32fV32f_V32f(float* x, float* y, float* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64fV64f_V64f")]
		private static unsafe extern Status yepCore_Min_V64fV64f_V64f(double* x, double* y, double* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8sS8s_V8s")]
		private static unsafe extern Status yepCore_Min_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V8uS8u_V8u")]
		private static unsafe extern Status yepCore_Min_V8uS8u_V8u(byte* x, byte y, byte* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16sS16s_V16s")]
		private static unsafe extern Status yepCore_Min_V16sS16s_V16s(short* x, short y, short* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V16uS16u_V16u")]
		private static unsafe extern Status yepCore_Min_V16uS16u_V16u(ushort* x, ushort y, ushort* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32sS32s_V32s")]
		private static unsafe extern Status yepCore_Min_V32sS32s_V32s(int* x, int y, int* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32uS32u_V32u")]
		private static unsafe extern Status yepCore_Min_V32uS32u_V32u(uint* x, uint y, uint* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64sS32s_V64s")]
		private static unsafe extern Status yepCore_Min_V64sS32s_V64s(long* x, int y, long* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64uS32u_V64u")]
		private static unsafe extern Status yepCore_Min_V64uS32u_V64u(ulong* x, uint y, ulong* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V32fS32f_V32f")]
		private static unsafe extern Status yepCore_Min_V32fS32f_V32f(float* x, float y, float* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_V64fS64f_V64f")]
		private static unsafe extern Status yepCore_Min_V64fS64f_V64f(double* x, double y, double* minimum, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV8sV8s_IV8s")]
		private static unsafe extern Status yepCore_Min_IV8sV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV8uV8u_IV8u")]
		private static unsafe extern Status yepCore_Min_IV8uV8u_IV8u(byte* x, byte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV16sV16s_IV16s")]
		private static unsafe extern Status yepCore_Min_IV16sV16s_IV16s(short* x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV16uV16u_IV16u")]
		private static unsafe extern Status yepCore_Min_IV16uV16u_IV16u(ushort* x, ushort* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32sV32s_IV32s")]
		private static unsafe extern Status yepCore_Min_IV32sV32s_IV32s(int* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32uV32u_IV32u")]
		private static unsafe extern Status yepCore_Min_IV32uV32u_IV32u(uint* x, uint* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64sV32s_IV64s")]
		private static unsafe extern Status yepCore_Min_IV64sV32s_IV64s(long* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64uV32u_IV64u")]
		private static unsafe extern Status yepCore_Min_IV64uV32u_IV64u(ulong* x, uint* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32fV32f_IV32f")]
		private static unsafe extern Status yepCore_Min_IV32fV32f_IV32f(float* x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64fV64f_IV64f")]
		private static unsafe extern Status yepCore_Min_IV64fV64f_IV64f(double* x, double* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV8sS8s_IV8s")]
		private static unsafe extern Status yepCore_Min_IV8sS8s_IV8s(sbyte* x, sbyte y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV8uS8u_IV8u")]
		private static unsafe extern Status yepCore_Min_IV8uS8u_IV8u(byte* x, byte y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV16sS16s_IV16s")]
		private static unsafe extern Status yepCore_Min_IV16sS16s_IV16s(short* x, short y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV16uS16u_IV16u")]
		private static unsafe extern Status yepCore_Min_IV16uS16u_IV16u(ushort* x, ushort y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32sS32s_IV32s")]
		private static unsafe extern Status yepCore_Min_IV32sS32s_IV32s(int* x, int y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32uS32u_IV32u")]
		private static unsafe extern Status yepCore_Min_IV32uS32u_IV32u(uint* x, uint y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64sS32s_IV64s")]
		private static unsafe extern Status yepCore_Min_IV64sS32s_IV64s(long* x, int y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64uS32u_IV64u")]
		private static unsafe extern Status yepCore_Min_IV64uS32u_IV64u(ulong* x, uint y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV32fS32f_IV32f")]
		private static unsafe extern Status yepCore_Min_IV32fS32f_IV32f(float* x, float y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Min_IV64fS64f_IV64f")]
		private static unsafe extern Status yepCore_Min_IV64fS64f_IV64f(double* x, double y, System.UIntPtr length);

	}

}
