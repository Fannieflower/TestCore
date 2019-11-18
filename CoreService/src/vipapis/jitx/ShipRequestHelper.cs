using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class ShipRequestHelper : TBeanSerializer<ShipRequest>
	{
		
		public static ShipRequestHelper OBJ = new ShipRequestHelper();
		
		public static ShipRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShipRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("ships".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.Ship> value;
						
						value = new List<vipapis.jitx.Ship>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.Ship elem0;
								
								elem0 = new vipapis.jitx.Ship();
								vipapis.jitx.ShipHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShips(value);
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
		
		
		public void Write(ShipRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetShips() != null) {
				
				oprot.WriteFieldBegin("ships");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.Ship _item0 in structs.GetShips()){
					
					
					vipapis.jitx.ShipHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ships can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShipRequest bean){
			
			
		}
		
	}
	
}