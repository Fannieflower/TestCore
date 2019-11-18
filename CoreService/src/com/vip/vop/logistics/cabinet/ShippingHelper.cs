using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class ShippingHelper : TBeanSerializer<Shipping>
	{
		
		public static ShippingHelper OBJ = new ShippingHelper();
		
		public static ShippingHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Shipping structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("outer_carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOuter_carrier_code(value);
					}
					
					
					
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("linkman".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Linkman value;
						
						value = new com.vip.vop.logistics.Linkman();
						com.vip.vop.logistics.LinkmanHelper.getInstance().Read(value, iprot);
						
						structs.SetLinkman(value);
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
		
		
		public void Write(Shipping structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOuter_carrier_code() != null) {
				
				oprot.WriteFieldBegin("outer_carrier_code");
				oprot.WriteString(structs.GetOuter_carrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLinkman() != null) {
				
				oprot.WriteFieldBegin("linkman");
				
				com.vip.vop.logistics.LinkmanHelper.getInstance().Write(structs.GetLinkman(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Shipping bean){
			
			
		}
		
	}
	
}