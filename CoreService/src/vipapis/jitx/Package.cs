using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class Package {
		
		///<summary>
		/// 箱计数,默认1
		///</summary>
		
		private int? box_no_;
		
		///<summary>
		/// 实际打包时间(epoch格式时间戳)。非空
		/// @sampleValue oqc_date 1545876212
		///</summary>
		
		private long? oqc_date_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 包裹号
		///</summary>
		
		private string package_no_;
		
		///<summary>
		/// 打包明细
		///</summary>
		
		private List<vipapis.jitx.PackageDetail> details_;
		
		public int? GetBox_no(){
			return this.box_no_;
		}
		
		public void SetBox_no(int? value){
			this.box_no_ = value;
		}
		public long? GetOqc_date(){
			return this.oqc_date_;
		}
		
		public void SetOqc_date(long? value){
			this.oqc_date_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public string GetPackage_no(){
			return this.package_no_;
		}
		
		public void SetPackage_no(string value){
			this.package_no_ = value;
		}
		public List<vipapis.jitx.PackageDetail> GetDetails(){
			return this.details_;
		}
		
		public void SetDetails(List<vipapis.jitx.PackageDetail> value){
			this.details_ = value;
		}
		
	}
	
}