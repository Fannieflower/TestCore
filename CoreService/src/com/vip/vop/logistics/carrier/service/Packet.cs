using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class Packet {
		
		///<summary>
		/// 运单号
		/// @sampleValue logistics_no 0001
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 包裹重量（单位:KG）,精确到4位小数（超出4位小数，则数据库自动取四舍五入）<br>只取第一次调用的数据，后续请求数据会自动忽略<br>，重量体积不能同时为空
		/// @sampleValue weight 1000
		///</summary>
		
		private string weight_;
		
		///<summary>
		/// 体积，单位为立方米（m³）,精确到4位小数（超出4位小数，则数据库自动取四舍五入）<br>只取第一次调用的数据，后续请求数据会自动忽略,<br>重量和体积不能同时为空！
		/// @sampleValue volume 0.24
		///</summary>
		
		private string volume_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(string value){
			this.weight_ = value;
		}
		public string GetVolume(){
			return this.volume_;
		}
		
		public void SetVolume(string value){
			this.volume_ = value;
		}
		
	}
	
}