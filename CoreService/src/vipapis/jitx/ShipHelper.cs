using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class ShipHelper : TBeanSerializer<Ship>
	{
		
		public static ShipHelper OBJ = new ShipHelper();
		
		public static ShipHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Ship structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("delivery_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDelivery_warehouse(value);
					}
					
					
					
					
					
					if ("total_package".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal_package(value);
					}
					
					
					
					
					
					if ("packages".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.Package> value;
						
						value = new List<vipapis.jitx.Package>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.Package elem0;
								
								elem0 = new vipapis.jitx.Package();
								vipapis.jitx.PackageHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPackages(value);
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
		
		
		public void Write(Ship structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetDelivery_warehouse() != null) {
				
				oprot.WriteFieldBegin("delivery_warehouse");
				oprot.WriteString(structs.GetDelivery_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("delivery_warehouse can not be null!");
			}
			
			
			if(structs.GetTotal_package() != null) {
				
				oprot.WriteFieldBegin("total_package");
				oprot.WriteI32((int)structs.GetTotal_package()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_package can not be null!");
			}
			
			
			if(structs.GetPackages() != null) {
				
				oprot.WriteFieldBegin("packages");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.Package _item0 in structs.GetPackages()){
					
					
					vipapis.jitx.PackageHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packages can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Ship bean){
			
			
		}
		
	}
	
}