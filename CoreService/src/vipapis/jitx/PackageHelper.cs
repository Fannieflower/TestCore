using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class PackageHelper : TBeanSerializer<Package>
	{
		
		public static PackageHelper OBJ = new PackageHelper();
		
		public static PackageHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Package structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("box_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBox_no(value);
					}
					
					
					
					
					
					if ("oqc_date".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOqc_date(value);
					}
					
					
					
					
					
					if ("transport_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_no(value);
					}
					
					
					
					
					
					if ("package_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPackage_no(value);
					}
					
					
					
					
					
					if ("details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.PackageDetail> value;
						
						value = new List<vipapis.jitx.PackageDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.PackageDetail elem0;
								
								elem0 = new vipapis.jitx.PackageDetail();
								vipapis.jitx.PackageDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetails(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(Package structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBox_no() != null) {
				
				oprot.WriteFieldBegin("box_no");
				oprot.WriteI32((int)structs.GetBox_no()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("box_no can not be null!");
			}
			
			
			if(structs.GetOqc_date() != null) {
				
				oprot.WriteFieldBegin("oqc_date");
				oprot.WriteI64((long)structs.GetOqc_date()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("oqc_date can not be null!");
			}
			
			
			if(structs.GetTransport_no() != null) {
				
				oprot.WriteFieldBegin("transport_no");
				oprot.WriteString(structs.GetTransport_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transport_no can not be null!");
			}
			
			
			if(structs.GetPackage_no() != null) {
				
				oprot.WriteFieldBegin("package_no");
				oprot.WriteString(structs.GetPackage_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("package_no can not be null!");
			}
			
			
			if(structs.GetDetails() != null) {
				
				oprot.WriteFieldBegin("details");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.PackageDetail _item0 in structs.GetDetails()){
					
					
					vipapis.jitx.PackageDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("details can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Package bean){
			
			
		}
		
	}
	
}