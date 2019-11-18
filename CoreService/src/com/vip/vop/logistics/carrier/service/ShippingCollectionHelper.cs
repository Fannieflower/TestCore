using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class ShippingCollectionHelper : TBeanSerializer<ShippingCollection>
	{
		
		public static ShippingCollectionHelper OBJ = new ShippingCollectionHelper();
		
		public static ShippingCollectionHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShippingCollection structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("trade_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrade_id(value);
					}
					
					
					
					
					
					if ("linkman".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Linkman value;
						
						value = new com.vip.vop.logistics.Linkman();
						com.vip.vop.logistics.LinkmanHelper.getInstance().Read(value, iprot);
						
						structs.SetLinkman(value);
					}
					
					
					
					
					
					if ("action".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAction(value);
					}
					
					
					
					
					
					if ("op_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetOp_time(value);
					}
					
					
					
					
					
					if ("reasonType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReasonType(value);
					}
					
					
					
					
					
					if ("packet".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.carrier.service.CollectionPacket value;
						
						value = new com.vip.vop.logistics.carrier.service.CollectionPacket();
						com.vip.vop.logistics.carrier.service.CollectionPacketHelper.getInstance().Read(value, iprot);
						
						structs.SetPacket(value);
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
		
		
		public void Write(ShippingCollection structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrade_id() != null) {
				
				oprot.WriteFieldBegin("trade_id");
				oprot.WriteString(structs.GetTrade_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trade_id can not be null!");
			}
			
			
			if(structs.GetLinkman() != null) {
				
				oprot.WriteFieldBegin("linkman");
				
				com.vip.vop.logistics.LinkmanHelper.getInstance().Write(structs.GetLinkman(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAction() != null) {
				
				oprot.WriteFieldBegin("action");
				oprot.WriteString(structs.GetAction());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("action can not be null!");
			}
			
			
			if(structs.GetOp_time() != null) {
				
				oprot.WriteFieldBegin("op_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetOp_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("op_time can not be null!");
			}
			
			
			if(structs.GetReasonType() != null) {
				
				oprot.WriteFieldBegin("reasonType");
				oprot.WriteString(structs.GetReasonType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPacket() != null) {
				
				oprot.WriteFieldBegin("packet");
				
				com.vip.vop.logistics.carrier.service.CollectionPacketHelper.getInstance().Write(structs.GetPacket(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShippingCollection bean){
			
			
		}
		
	}
	
}