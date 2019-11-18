using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics{
	
	
	
	public class ShippingAddressHelper : TBeanSerializer<ShippingAddress>
	{
		
		public static ShippingAddressHelper OBJ = new ShippingAddressHelper();
		
		public static ShippingAddressHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShippingAddress structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Address value;
						
						value = new com.vip.vop.logistics.Address();
						com.vip.vop.logistics.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("linkman".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Linkman value;
						
						value = new com.vip.vop.logistics.Linkman();
						com.vip.vop.logistics.LinkmanHelper.getInstance().Read(value, iprot);
						
						structs.SetLinkman(value);
					}
					
					
					
					
					
					if ("trade_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrade_id(value);
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
		
		
		public void Write(ShippingAddress structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				
				com.vip.vop.logistics.AddressHelper.getInstance().Write(structs.GetAddress(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLinkman() != null) {
				
				oprot.WriteFieldBegin("linkman");
				
				com.vip.vop.logistics.LinkmanHelper.getInstance().Write(structs.GetLinkman(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrade_id() != null) {
				
				oprot.WriteFieldBegin("trade_id");
				oprot.WriteString(structs.GetTrade_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShippingAddress bean){
			
			
		}
		
	}
	
}